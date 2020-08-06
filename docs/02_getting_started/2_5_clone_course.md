## Cloning a Repository  


### Use HTTPS!

After you create your course repository (see Environment Setup activity on FSO), you will need to clone it down to your computer. A clone is a copy of your online repository that you can edit locally on your computer. You can then push your edits back to the online version of the repository to make sure the two repositories (local and GitHub) have the same edits. The easiest way to clone a repository is to use the HTTPS protocol. 

It is strongly recommended that you clone with HTTPS, not SSH. If you have a reason for using SSH please reach out to your instructor for approval. 

# Cloning Your Repo

## **Step 1: Copy the HTTPS URL**  
Here's how to clone your repository... 

While viewing your GitHub class repository, you will see a green button that you can use to clone your repository to your computer. Click the icon next to the HTTPS URL. This will copy the http address to your clipboard. 

![clone_https_sm](https://user-images.githubusercontent.com/613813/86562289-775adb80-bf30-11ea-90df-e320674e3f95.jpg)

**DO NOT** use the SSH url, which looks like the following...

![clone_ssh_sm](https://user-images.githubusercontent.com/613813/86562301-7c1f8f80-bf30-11ea-9bae-e768627ae5a3.jpg)


 

<br>

**Why HTTPS is preferred**

1. Easier to setup (than SSH)
2. Works better behind a firewall
3. Works with Mac OSX credential helper

<br>

## **Step 2: Clone the Repo to your Desktop**
Open the Terminal application on your Mac. Navigate to your desktop, and paste in the "Clone with HTTPS" url along with the git clone command. Make sure the URL looks like the example below, replace the hash (#) symbols with your own repo address.

``` 
cd ~/Desktop 
git clone https://github.com/ePortfolios/adf-####-####.git

```

### **Provide your GitHub Credentials**  
When using the HTTPS protocol with Git in Terminal for the first time, you may be asked for your GitHub username and password. Go ahead and provide this information. This should save the information for future use.

If you continue to be asked for a username and password every time you run git commands, the recommendation is to install the *OSX Keychain Helper*. Once installed, your username and password will be stored after the first successful login to a repository. 

[GitHub Article](https://help.github.com/articles/caching-your-github-password-in-git/): Explains how to setup the OSX Keychain Helper. Only necessary if you are continually asked to enter your username and password when connecting to GitHub.

<br>

## **Step 3: Navigate into the Desktop Repo**
After cloning the repository to your desktop, navigate inside the folder using Terminal. Replace the hash symbols below with the correct folder title. This folder is your local copy of the repository.

```
cd ~/Desktop/adf-####-#### 
```
Once you have navigated inside the folder you can begin to use Git commands. Git commands only work if you are currently inside a repository folder. You can confirm Terminal is "Inside" the correct location by using the following Terminal command...

```
pwd

```

pwd will "print the working directory". In other words, it will tell you where Terminal is currently pointing. If it looks like this... 

```
/Users/YourMacUserName/Desktop/adf-####-####
 
```
...then you are inside your repository and ready to start using Git commands!








