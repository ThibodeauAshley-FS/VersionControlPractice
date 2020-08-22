# Instructions 
Update this document where indicated (brackets). Replace text inside the brackets with your own information. For example: Course Name should be the name of this course, and not the generic words "Course Name".

**Note:** As you complete each item, also update reference links where indicated below. 

<br>

## ADF

* **3.3 File I/O**
* **Ashley Thibodeau**
* **Sun Aug 23, 2020**

This paper addresses some of the topic matter covered in research and activity this week. Be sure to include reference links below to the research and information you used to complete this assignment.

## Topic: Working with Data
Update the information below to demonstrate your knowledge on this topic.   

**1. Using Dictionary values as a Data Source.**

A dictionary is useful for working with data. Identify what's wrong with the code block below. How would you fix the issue(s)? The output to console should match the "**Expected Output**" shown below. 

Identify at least three issues with the code and how each can be fixed... 

- **Issue 1:** [ Describe issue and how this can be fixed ]  
- **Issue 2:** [ Describe issue and how this can be fixed ]  
- **Issue 3:** [ Describe issue and how this can be fixed ]

  
    
```c#
            Dictionary<string, List<string>> myBooks = new Dictionary<string, List<string>>()
            {
                { "C", new List<string>()},
                { "JavaScript", new List<string>() },
                { "SQL", new List<string>() }
            };

            myBooks["C#"].Add("Visual C# Step by Step");
            myBooks["JavaScript"].Add("Learning JavaScript Design Patterns");

            foreach (KeyValuePair<string, List<string>> item in myBooks)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n*** {item} *******");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var book in item.Value)
                {
                    Console.WriteLine(book);
                }
            }

```

**Expected Output:** 

```
*** C# *******
Visual C# Step by Step

*** JavaScript *******
Learning JavaScript Design Patterns

*** SQL *******
Practical SQL

```

<br>


**2. Using a User object as a data source**

A dictionary can store objects. Imagine a User class that contains the following properties: **Name**, **City**, **State**, and **Id**. The code block below instantiates a new instance of this class and gives that instance (i.e. the new user object) some values. With that new object created, we add it to a dictionary. We then cycle through the dictionary to print out the new user object values to the console. 

Identify what's wrong with the code block below. How would you fix the issue(s)? The output to console should match the "**Expected Output**" shown below. 

Identify at least three issues with the code and how each can be fixed... 

- **Issue 1:** [ Describe issue and how this can be fixed ]  
- **Issue 2:** [ Describe issue and how this can be fixed ]  
- **Issue 3:** [ Describe issue and how this can be fixed ]

 
```c#
using System;
using System.Collections.Generic;

namespace Lab
{
    public class App
    {
        public App()
        {
            User user = new User("John Doe", "Winter Park", "Florida", 1234);

            Dictionary<string, List<User>> users = new Dictionary<string, List<User>>();

            users.Add("Members", new List<User>());
            users["Members"].Add(user);

            foreach (KeyValuePair<string, List<User>> userCategory in users)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n*** {userCategory} *******");
                Console.ForegroundColor = ConsoleColor.White;

                foreach (var individual in userCategory)
                {
                    Console.WriteLine(individual.Name);
                    Console.WriteLine(individual.City);
                    Console.WriteLine(individual.State);
                    Console.WriteLine(individual.Id);
                }
            }
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Id { get; set; }

        public User(string name, string city, string state, int id)
        {
            Console.WriteLine("User Created!");
        }
    }
}


```


**Expected Output:** 

```
User Created!

*** Members *******
John Doe
Winter Park
Florida
1234

```

<br>


## Topic: Read and Write Data
An application has more flexibility when it is able to both store and retrieve data. Using C# and the File, StreamReader, and StreamWriter classes gives us this ability. Any data read from a file can be stored for later use by using data structures. For example, a newly created User object (instance of the User class) may have a Name property. Data read from a file can be used to update the name value of that new instance.     
 

**1. From your research and use of the StreamReader class, respond to the following.**


- **A.** What namespace is used with the StreamReader class?: System.IO
- **B.** Describe how you would check to see if a file has any additional lines to read when using the StreamReader class: [ Response Here ]  
- **C.** When creating a new StreamReader, what information is expected after the keyword "new"?
[ Response Here: include an example ]


**2. Demonstrate how to use the StreamWriter class to write to a file. Include the following: A using statement, a StreamWriter object, and use of the File.AppendText() method. Explain each part of the code in your own words.**

```

[ Provide Code here with comments... ]


```
    

**3. What is the difference between a property and an auto implemented property? When would you use one over the other..**

[ Response Here ]



**4. If a class member contains the keyword "static", how do you use this outside of the defining class?. Provide an example with an explanation.**  


```

[ Provide Code here with comments... ]


```

<br>

# Reference Links
Replace the example references below with your own independent research. Do not use material already provided to you in this class. Two or more references are needed for each topic below.

**Working with Data**  
[Site Address](https://www.someaddress.com/full/url/)  

[ Summarize Here: How did this resource help you? ]


[Site Address](https://www.someaddress.com/full/url/)  

[ Summarize Here: How did this resource help you? ]


**Read and Write Data**  
[Site Address](https://www.someaddress.com/full/url/)

[ Summarize Here: How did this resource help you? ]


[Site Address](https://www.someaddress.com/full/url/)  

[ Summarize Here: How did this resource help you? ]






