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

    private ContextMenu trayMenu;
    private NotifyIcon trayIcon;

    private List<PasswordDomain> userDomains;
    private string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PasswordHasher\\savedDomains";

    public Form1()
    {
      InitializeComponent();

      sendPasswordToWindow = new EventHandler(onDeactivate);

      if (Properties.Settings.Default.Salts == null)
        Properties.Settings.Default.Salts = new StringCollection();

      // Load settings
      trayCheckBox.Checked = Properties.Settings.Default.Tray;
      enterCheckBox.Checked = Properties.Settings.Default.SendEnter;
      ontopCheckBox.Checked = Properties.Settings.Default.OnTop;

      // Get saved domains
      LoadDomains();

      saltBox.DataSource = userDomains;
      saltBox.DisplayMember = "domain";
      saltBox.ValueMember = "domain";

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
      if (string.IsNullOrEmpty(saltBox.Text))
        return null;

      PasswordDomain current = userDomains.Find((PasswordDomain p) =>
      {
        return (p.domain == saltBox.Text);
      }
      );
      if (current == null)
      {
        PasswordDomain n = new PasswordDomain(saltBox.Text);
        userDomains.Add(n);

        saltBox.DataSource = null;
        saltBox.DataSource = userDomains;
        saltBox.DisplayMember = "domain";
        saltBox.ValueMember = "domain";
        saltBox.SelectedItem = n;
      }

      return current;
    }

    private void DoGenerateHash()
    {
      if (string.IsNullOrEmpty(saltBox.Text) || string.IsNullOrEmpty(passBox.Text))
      {
        outputBox.Text = "";
        return;
      }

      outputBox.Text = PasswordHash(passBox.Text + saltBox.Text, (int)lengthControl.Value, (int)iterationsControl.Value, lowersCheckBox.Checked, uppersCheckBox.Checked, numericCheckBox.Checked, specialCheckBox.Checked);
    }


    private void GenerateTrayMenu()
    {
      trayMenu.MenuItems.Add("Exit", onExit);
    }

    private string PasswordHash(string data, int length, int iterations, bool doLowers, bool doUppers, bool doNumerals, bool doSpecials)
    {
      if (!doLowers && !doUppers && !doNumerals && !doSpecials)
        return "";

      string loweralphas = "abcdefghijklmnopqrstuvwxyz";
      string upperalphas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string numerals = "0123456789";
      string specials = "(){}[]<>/\\|-=+*_,.;:`\"'~!@#$%^&";

      string hashAlphabet = "";
      if (doLowers) hashAlphabet = hashAlphabet + loweralphas;
      if (doUppers) hashAlphabet = hashAlphabet + upperalphas;
      if (doNumerals) hashAlphabet = hashAlphabet + numerals;
      if (doSpecials) hashAlphabet = hashAlphabet + specials;
      int alphabetLength = hashAlphabet.Length;

      StringBuilder result = new StringBuilder();

      using (SHA256 sha = SHA256.Create())
      {
        byte[] hashData = Encoding.UTF8.GetBytes(data);

        // Iterate the hash
        for (int i = 0; i < iterations; i++)
        {
          hashData = sha.ComputeHash(hashData);
        }

        // Create the output
        for (int i = 0; i < length; i++)
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
      PasswordDomain current = userDomains.Find((PasswordDomain p) =>
      {
        return (p.domain == saltBox.Text);
      }
      );
      if (current != null)
      {
        userDomains.Remove(current);

        saltBox.DataSource = null;
        saltBox.DataSource = userDomains;
        saltBox.DisplayMember = "domain";
        saltBox.ValueMember = "domain";
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
        SendKeys.SendWait(outputBox.Text[i].ToString());
        // Wait some time between sending each character
        System.Threading.Thread.Sleep(50);
      }

      if (enterCheckBox.Checked)
      {
        SendKeys.Send("{ENTER}");
      }

      Deactivate -= sendPasswordToWindow;
      Cursor = Cursors.Default;
      outputBox.Clear();
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
    }

    private void lengthControl_ValueChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      p.length = (int)lengthControl.Value;

      DoGenerateHash();

      SaveSalts();
    }

    private void iterationsControl_ValueChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      p.iterations = (int)iterationsControl.Value;

      DoGenerateHash();

      SaveSalts();
    }

    private void uppersCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      p.uppers = uppersCheckBox.Checked;

      DoGenerateHash();

      SaveSalts();
    }

    private void lowersCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      p.lowers = lowersCheckBox.Checked;

      DoGenerateHash();

      SaveSalts();
    }

    private void numericCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      p.numerals = numericCheckBox.Checked;

      DoGenerateHash();

      SaveSalts();
    }

    private void specialCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      PasswordDomain p = GetSelectedDomain();
      if (p == null) return;

      p.specials = specialCheckBox.Checked;

      DoGenerateHash();

      SaveSalts();
    }

    private void saltBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      PasswordDomain p = saltBox.SelectedItem as PasswordDomain;
      if (p == null) return;

      if (p.length >= lengthControl.Minimum && p.length <= lengthControl.Maximum)
        lengthControl.Value = p.length;

      if (p.iterations >= iterationsControl.Minimum && p.iterations <= iterationsControl.Maximum)
        iterationsControl.Value = p.iterations;

      uppersCheckBox.Checked = p.uppers;
      lowersCheckBox.Checked = p.lowers;
      numericCheckBox.Checked = p.numerals;
      specialCheckBox.Checked = p.specials;

      DoGenerateHash();
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

    public string domain { get; set; }
    public int length;
    public int iterations;
    public bool uppers;
    public bool lowers;
    public bool numerals;
    public bool specials;
  }
}
