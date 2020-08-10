# Instructions 
Update this document where indicated (brackets). Replace text inside the brackets with your own information. For example: Course Name should be the name of this course, and not the generic words "Course Name".

**Note:** As you complete each item, also update reference links where indicated below. 

<br>

## ADF

* **1.6 Version Control & Workflow**
* **Ashley Thibodeau**
* **Aug 9, 2020**

This paper addresses some of the topic matter covered in research and activity this week. Be sure to include reference links below to the research and information you used to complete this assignment.

## Topic: Terminal
Professional developers use Terminal daily. It's essential to understand some fundamental commands to use the application. 

Update the information below to demonstrate your knowledge on this topic.   

**1. Using Terminal, there are essential commands to know.**

List the correct Terminal commands to do the actions listed below. Replace **CMD** with the correct command sequence. You can keep or enhance the brief description. 

**The last bullet provides an example**.

* Ctrl + L : Clear the Screen 
* pwd : Print the "Working Directory"
* ls : List files and folders
* ls -la : List files and folders, including invisible files
* ls -lh : List all files and folders, in human readable form
* cd[folder] : Change directory
* cd/ : Change directory, go to root directory
* cd ~ : Change directory and go to user home directory
* cd.. : Change directory, go up one folder level
* cd../.. : Change directory, go up two folder levels
* **cd ~/Desktop/**: Change directory to my desktop! 


**2. Using Terminal...**

**Folder Drop:** Describe what happens when you drag a folder into Terminal. If you type "cd " before dragging the folder into Terminal and press return after dragging a folder to Terminal, could that help you quickly navigate to the folder location? Test this out and describe your results below. 

When you enter "cd " then drag and drop into the Terminal followed by pressing enter it changes the location to that folder. It is a quicker method to changing to folders.


## Topic: Version Control & Git
Version control, also known as revision control, records changes to a file or set of files over time so that you can recall specific versions later. In this class, we are learning Git. Update the information below where indicated.  

**1. There are three types of version control.**

* 	Types of version control:
 * Local Version Control Systems
 * Centralized Version Control Systems
 * Distributed Version Control Systems

1. Local Version Control Systems keep track of the files within the local system. It's the simplest form of version control.
2. Centralized Version Control Systems have one main repo while each user gets their own copy. once the user commits their changes, the central repo is updated to reflect it.
3. Distributed Version Control Systems contain multple repoistories for each user which including it;s full history. There is no centralized spot.



**2. Using Terminal, there are also essential Git commands to know.**

List the correct Git commands to do the actions listed below in Terminal. Replace CMD with the correct command and keep or enhance the brief description. **The last bullet provides an example**. 

* $ git clone [url] : Clone a repository
* $ git config --global user.name "[name]" : Set-up a global user name
* $ git config --global user.email "[email address]" : Set-up a global email address (to match my GitHub account eMail)
* git status : Show the working tree status.
* git add [file/directory]: Add modified files to the next commit
* git commit -m': Make a commit with a new message
* git log: Show my commit history
* **git help**: This command will bring up Git's help screen in Terminal!
    



**3. Connecting to GitHub using Terminal.**
HTTPS is the the correct way to connect to GitHub in this course. Describe how you connect to GitHub from Terminal using this protocol. What steps do you take? 
 
 1. Copy the HTTPS URL
 2. Clone the Repo to your Desktop and enter your credentials
 3. Navigate into the Desktop Repo using:
  * cd ~/Desktop/adf-####-#### 
  


**4. Using .gitignore and Why it's Important**  
Most repositories contain a .gitignore file. 

* What is the purpose of this file?  
* What is the "**.DS_Store**" file and why would you want to ignore it?
* What other file or folder would you want to add to a .gitignore file and why? 


The purpose of the .gitignore is to make sure certain files are not tracked by Git. The .DS_Store file is an invisable file that gets automaticly created anytime you look into a folder with finder on a mac. You would want to ignore it because it they can hold sensitive information and cause potiental security breaches. Other folders and files you wouuld want to include would include files such as Application files, Language and framework files, files downloaded with package managers, credential files. Aside from security that could be potentially be at risk, we also want to ignore these files to reduce unneeded clutter that could cause conflicts.



<br>

# Reference Links
Replace the example references below with your own links and recommended resources. It is acceptable to provide multiple links for a single topic and to use material provided to you in this class. You are encouraged to link to your own independent research as well. 

I found these resources most helpful because they explain these topics in a more simple manner. After finding them I felt I was able to have a better understanding of the topics in this document.

**Terminal Commands**  
[Site Address](https://www.makeuseof.com/tag/mac-terminal-commands-cheat-sheet/)  

**Three Types of Version Control**  
[Site Address](https://blog.eduonix.com/software-development/learn-three-types-version-control-systems/)

**Git Commands**  
[Site Address](https://git-scm.com/docs)

**Connecting to GitHub using Terminal**  
[Site Address](https://guides.github.com/activities/hello-world/#repository)

**Using .gitignore and Why it's Important**   
 [Site Address](https://zellwk.com/blog/gitignore/)




