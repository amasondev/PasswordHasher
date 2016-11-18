using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace PasswordHasher
{
  public partial class Form1 : Form
  {
    private EventHandler sendPasswordToWindow;
    private BindingSource domainBindingSource = new BindingSource();

    private ContextMenu trayMenu;
    private NotifyIcon trayIcon;

    private List<PasswordDomain> userDomains;
    private string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PasswordHasher\\savedDomains";

    public Form1()
    {
      InitializeComponent();

      sendPasswordToWindow = new EventHandler(onDeactivate);

      trayIcon = new NotifyIcon();
      trayIcon.Text = "Password Hasher";
      trayIcon.BalloonTipText = "Password Hasher minimized to tray.";
      trayIcon.BalloonTipTitle = "Password Hasher";
      trayIcon.Icon = this.Icon;
      trayIcon.DoubleClick += (sender, e) =>
      {
        WindowState = FormWindowState.Normal;
        ShowInTaskbar = true;
        trayIcon.Visible = false;
      };
      trayMenu = new ContextMenu();
      GenerateTrayMenu();
      trayIcon.ContextMenu = trayMenu;
      trayIcon.Visible = false;

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      LoadDomains();
      domainBindingSource.DataSource = userDomains;
      saltBox.DataSource = domainBindingSource;
      saltBox.DisplayMember = "domain";

      PasswordDomain p = saltBox.SelectedItem as PasswordDomain;
      SelectDomain(p);

      // Load settings
      trayCheckBox.Checked = Properties.Settings.Default.Tray;
      enterCheckBox.Checked = Properties.Settings.Default.SendEnter;
      ontopCheckBox.Checked = Properties.Settings.Default.OnTop;
    }

    private void LoadDomains()
    {
      try
      {
        using (Stream stream = File.OpenRead(dataPath))
        {
          BinaryFormatter formatter = new BinaryFormatter();
          userDomains = (List<PasswordDomain>)formatter.Deserialize(stream);
          stream.Close();
        }
      }
      catch (DirectoryNotFoundException e)
      {
        // File not found, it will be created
        userDomains = new List<PasswordDomain>();

      }
      catch (FileNotFoundException e)
      {
        // File not found, it will be created
        userDomains = new List<PasswordDomain>();

      }
      catch (Exception e)
      {
        userDomains = new List<PasswordDomain>();
        MessageBox.Show(e.Message);
      }
    }

    private void SaveSalts()
    {
      Console.WriteLine("[DEBUG] Saving salts.");

      GetSelectedDomain();

      try
      {
        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PasswordHasher");
        using (Stream stream = File.Open(dataPath, FileMode.Create))
        {
          BinaryFormatter formatter = new BinaryFormatter();
          formatter.Serialize(stream, userDomains);
          stream.Close();
        }
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
    }

    private PasswordDomain GetSelectedDomain()
    {
      PasswordDomain existing = saltBox.SelectedItem as PasswordDomain;
      if (existing != null) return existing;

      if (string.IsNullOrWhiteSpace(saltBox.Text))
        return null;

      PasswordDomain current = userDomains.Find((PasswordDomain p) =>
      {        
        return (p.domain == saltBox.Text);
      }
      );
      if (current == null)
      {
        Console.WriteLine("[DEBUG] Creating new PasswordDomain: " + saltBox.Text);
        current = new PasswordDomain(saltBox.Text);
        userDomains.Add(current);

        domainBindingSource.SuspendBinding();
        domainBindingSource.ResumeBinding();

        saltBox.SelectedItem = current;
      }

      return current;
    }

    private void DoGenerateHash()
    {
      if (string.IsNullOrWhiteSpace(saltBox.Text) || string.IsNullOrEmpty(passBox.Text))
      {
        outputBox.Text = "";
        return;
      }

      Console.WriteLine("[DEBUG] Generating hash for " + saltBox.Text);

      outputBox.Text = PasswordHash(passBox.Text,
        new PasswordDomain(
          saltBox.Text,
          (int)lengthControl.Value,
          (int)iterationsControl.Value,
          uppersCheckBox.Checked,
          lowersCheckBox.Checked,
          numericCheckBox.Checked,
          specialCheckBox.Checked
          )
        );
    }

    private void DoGenerateHash(PasswordDomain p)
    {
      if (p == null || string.IsNullOrEmpty(passBox.Text))
      {
        outputBox.Text = "";
        return;
      }
      Console.WriteLine("[DEBUG] Generating hash for " + p.domain);

      outputBox.Text = PasswordHash(passBox.Text, p);
    }


    private void GenerateTrayMenu()
    {
      trayMenu.MenuItems.Add("Exit", onExit);
    }

    private string PasswordHash(string password, PasswordDomain domain)
    {
      if (domain == null || !domain.IsValid())
        return "";

      string loweralphas = "abcdefghijklmnopqrstuvwxyz";
      string upperalphas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string numerals = "0123456789";
      string specials = "(){}[]<>/\\|-=+*_,.;:`\"'~!@#$%^&";

      string hashAlphabet = "";
      if (domain.lowers) hashAlphabet = hashAlphabet + loweralphas;
      if (domain.uppers) hashAlphabet = hashAlphabet + upperalphas;
      if (domain.numerals) hashAlphabet = hashAlphabet + numerals;
      if (domain.specials) hashAlphabet = hashAlphabet + specials;
      int alphabetLength = hashAlphabet.Length;

      StringBuilder result = new StringBuilder();

      using (SHA256 sha = SHA256.Create())
      {
        byte[] hashData = Encoding.UTF8.GetBytes(password + domain.domain);

        // Iterate the hash
        for (int i = 0; i < domain.iterations; i++)
        {
          hashData = sha.ComputeHash(hashData);
        }

        // Create the output
        for (int i = 0; i < domain.length; i++)
        {
          // Iterate the hash as output length increases
          byte[] longHashData = hashData;
          for (int j = 0; j < i / hashData.Length; j++)
            longHashData = sha.ComputeHash(longHashData);

          int index = longHashData[i % longHashData.Length];

          result.Append(hashAlphabet[index % hashAlphabet.Length]);
        }
      }

      return result.ToString();
    }

    private void removeSaltButton_Click(object sender, EventArgs e)
    {
      PasswordDomain current = GetSelectedDomain();

      if (current != null)
      {
        Console.WriteLine("[DEBUG] Removing PasswordDomain: " + current.domain);
        userDomains.Remove(current);
        domainBindingSource.SuspendBinding();
        domainBindingSource.ResumeBinding();
        saltBox.SelectedIndex = 0;
      }

      SaveSalts();
    }

    private void sendButton_Click(object sender, EventArgs e)
    {
      // Save the salt to the dropdown box
      SaveSalts();

      if (string.IsNullOrEmpty(outputBox.Text)) return;

      Deactivate += sendPasswordToWindow;

      Cursor = Cursors.Cross;
    }

    private void onDeactivate(object sender, EventArgs e)
    {
      System.Threading.Thread.Sleep(300);
      for (int i = 0; i < outputBox.Text.Length; i++)
      {
        string key = outputBox.Text[i].ToString();
        if (key == "+" || key == "^" || key == "%" || key == "~" || key == "(" || key == ")" || key == "{" || key == "}")
        {
          key = "{" + key + "}";
        }

        SendKeys.SendWait(key);

        // Wait some time between sending each character
        System.Threading.Thread.Sleep(50);
      }

      if (enterCheckBox.Checked)
      {
        SendKeys.Send("{ENTER}");
      }

      Deactivate -= sendPasswordToWindow;
      Cursor = Cursors.Default;
      passBox.Clear();
    }

    private void onExit(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void displayCheckBox_Click(object sender, EventArgs e)
    {
      outputBox.UseSystemPasswordChar = !displayCheckBox.Checked;
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
      if (trayCheckBox.Checked && WindowState == FormWindowState.Minimized)
      {
        trayIcon.Visible = true;
        trayIcon.ShowBalloonTip(5000);
        ShowInTaskbar = false;
      }
    }

    private void trayCheckBox_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.Tray = trayCheckBox.Checked;
      Properties.Settings.Default.Save();
    }

    private void ontopCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      TopMost = ontopCheckBox.Checked;
      Properties.Settings.Default.OnTop = ontopCheckBox.Checked;
      Properties.Settings.Default.Save();
    }

    private void enterCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      Properties.Settings.Default.SendEnter = enterCheckBox.Checked;
      Properties.Settings.Default.Save();
    }

    private void passBox_TextChanged(object sender, EventArgs e)
    {
      DoGenerateHash();
    }

    private void copyButtonClicked(object sender, EventArgs e)
    {
      Clipboard.SetText(outputBox.Text);
      SaveSalts();

      passBox.Clear();
    }

    private void lengthControl_ValueChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      Console.WriteLine("[DEBUG] Setting " + p.domain + " length to " + lengthControl.Value.ToString());
      p.length = (int)lengthControl.Value;

      DoGenerateHash();

      SaveSalts();
    }

    private void iterationsControl_ValueChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      Console.WriteLine("[DEBUG] Setting " + p.domain + " iterations to " + iterationsControl.Value.ToString());
      p.iterations = (int)iterationsControl.Value;

      DoGenerateHash();

      SaveSalts();
    }

    private void uppersCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      Console.WriteLine("[DEBUG] Setting " + p.domain + " uppers to " + uppersCheckBox.Checked.ToString());
      p.uppers = uppersCheckBox.Checked;

      DoGenerateHash();

      SaveSalts();
    }

    private void lowersCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      Console.WriteLine("[DEBUG] Setting " + p.domain + " lowers to " + lowersCheckBox.Checked.ToString());
      p.lowers = lowersCheckBox.Checked;

      DoGenerateHash();

      SaveSalts();
    }

    private void numericCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      Console.WriteLine("[DEBUG] Setting " + p.domain + " numerals to " + numericCheckBox.Checked.ToString());
      p.numerals = numericCheckBox.Checked;

      DoGenerateHash();

      SaveSalts();
    }

    private void specialCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      Console.WriteLine("[DEBUG] Setting " + p.domain + " specials to " + specialCheckBox.Checked.ToString());
      p.specials = specialCheckBox.Checked;

      DoGenerateHash();

      SaveSalts();
    }

    private void SelectDomain(PasswordDomain p)
    {
      if (p == null) return;

      saltBox.SelectedItem = p;

      Console.WriteLine("[DEBUG] saltBox Selection changed to: " + p.domain);
      p.PrintInfo();

      if (p.length >= lengthControl.Minimum && p.length <= lengthControl.Maximum)
        lengthControl.Value = p.length;

      if (p.iterations >= iterationsControl.Minimum && p.iterations <= iterationsControl.Maximum)
        iterationsControl.Value = p.iterations;

      uppersCheckBox.Checked = p.uppers;
      lowersCheckBox.Checked = p.lowers;
      numericCheckBox.Checked = p.numerals;
      specialCheckBox.Checked = p.specials;

      DoGenerateHash(p);
    }

    private void saltBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      PasswordDomain p = saltBox.SelectedItem as PasswordDomain;
      if (p == null) return;
      
      SelectDomain(p);
    }

    private void saltBox_TextUpdate(object sender, EventArgs e)
    {
      DoGenerateHash();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        Deactivate -= sendPasswordToWindow;
        Cursor = Cursors.Default;
      }
    }

  }

  [Serializable]
  public class PasswordDomain
  {
    public PasswordDomain(string domain, int length = 32, int iterations = 1, bool uppers = true, bool lowers = true, bool numerals = true, bool specials = true)
    {
      this.domain = domain;
      this.length = length;
      this.iterations = iterations;
      this.uppers = uppers;
      this.lowers = lowers;
      this.numerals = numerals;
      this.specials = specials;
    }

    public bool IsValid()
    {
      return (uppers || lowers || numerals || specials);
    }

    public void PrintInfo()
    {
      Console.WriteLine("[Debug] " + domain + " information:");
      Console.WriteLine("Domain: " + domain);
      Console.WriteLine("Length: " + length.ToString());
      Console.WriteLine("Iterations: " + iterations.ToString());

      string bools = "";
      if (uppers) bools += "uppers, ";
      if (lowers) bools += "lowers, ";
      if (numerals) bools += "numerals, ";
      if (specials) bools += "specials, ";

      Console.WriteLine(bools);
    }

    public string domain { get; set; }
    public int length;
    public int iterations;
    public bool uppers;
    public bool lowers;
    public bool numerals;
    public bool specials;
  }
}
