# PasswordHasher
Easily hash your favourite password and send to other applications.

![Screenshot](https://raw.githubusercontent.com/veridiam/PasswordHasher/master/Images/Screenshot.png)

PasswordHasher takes an ordinary password and combines it with a given salt to generate an MD5 hash in the same way Unix stores its password hashes.

This can be used to generate highly secure passwords from less secure ones. It also gives you the ability to use one password, with a unique password for each place of use.

The salts you enter are saved, allowing you to store them for each place of use.

The Send button allows you to transport the hash without use of the insecure clipboard.

![Screenshot](https://raw.githubusercontent.com/veridiam/PasswordHasher/master/Images/Example.png)

## Download
Download the latest release [Here](https://github.com/veridiam/PasswordHasher/releases)

At this time, PasswordHasher is only available for Windows. For Linux and OS X users, I recommend using:

    openssl passwd -1 -salt yoursalt yourpassword
	
This will generate the same hash as PasswordHasher.

## Questions
#### Why is the salt limited to 8 characters?
At the moment the hashing algorithm used is identical to that used in Unix crypt, for the sake of compatibility. If you want to add additional uniqueness to your hash, it should be done in the password.

## The Future
I would like to release PasswordHasher for Android and iOS at some point, but am still unsure of implementation. If you have any suggestions, let me know.

One thing that could increase security is an optional mutation string, which would allow you to change the hash but keep the same password and salt, in the case that the hash is comprimised for any reason. However, this would break compatibility with Unix crypt.
