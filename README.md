# PasswordHasher
Easily hash your favourite password and send to other applications.

![Screenshot](https://raw.githubusercontent.com/veridiam/PasswordHasher/master/Images/Screenshot.png)

PasswordHasher takes an ordinary password and combines it with a given salt to generate an MD5 hash in the same way Unix stores its password hashes.

This can be used to generate highly secure passwords from less secure ones. It also gives you the ability to use one password, with a unique password for each place of use.

The salts you enter are saved, allowing you to store them for each place of use.

The Send button allows you to transport the hash without use of the insecure clipboard.

## Download
Download the latest release [Here](https://github.com/veridiam/PasswordHasher/releases)

At this time, PasswordHasher is only available for Windows. For Linux and OS X users, I recommend using:

    openssl passwd -1 -salt yoursalt yourpassword
	
This will generate the same hash as PasswordHasher.

## The Future
I would like to release PasswordHasher for Android and iOS at some point, but am still unsure of implimentation. If you have any suggestions, let me know.