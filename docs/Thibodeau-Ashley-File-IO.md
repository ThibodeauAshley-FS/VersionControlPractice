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

- **Issue 1:** KeyNotFoundException: The given key 'C#' was not present in the dictionary.
 *  change this: `{ "C", new List<string>()},` 
 *  to this: ` { "C#", new List<string>()},`
- **Issue 2:**  *** [C#, System.Collections.Generic.List`1[System.String]] *******
 * Foreach item will display key, and type of list, not its contents. Foreach item.Key the item.Value must be looped to display its contents.
 * change this: `Console.WriteLine($"\n*** {item} *******");` 
 * to this: `Console.WriteLine($"\n*** {item.Key} *******");`
- **Issue 3:** Missing list value entry for SQL
 * ADD: `myBooks["SQL"].Add("Practical SQL");`

  
    
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

- **Issue 1:** Missing setting the parameters to the fields in the User Constructor
 * ADD to user constructor:   
     `Name = name;` `City = city;` `State = state;` `Id = id;`
	 
- **Issue 2:**  `Console.WriteLine($"\n*** {userCategory} *******");`
 * Prints both key and list value type because 
 * change to `Console.WriteLine($"\n*** {userCategory.Key} *******");`
- **Issue 3:** `foreach (var individual in userCategory)`
 * foreach statement cannot operate on its set variables(string, list of user data) because the variables are not properly called. To be more specific, the values of the user data list is not properly called for each key item in the outer foreach loop.
 * change to: `foreach (var individual in userCategory.Value)`

 
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


- **A.** What namespace is used with the StreamReader class?: 
 - System.IO
- **B.** Describe how you would check to see if a file has any additional lines to read when using the StreamReader class:
 - you would check to see if a file has any additional lines to read by using a while loop until the value is returned as Null.
- **C.** When creating a new StreamReader, what information is expected after the keyword "new"?
 - It is expecting a new StreamerReader and path to the file


**2. Demonstrate how to use the StreamWriter class to write to a file. Include the following: A using statement, a StreamWriter object, and use of the File.AppendText() method. Explain each part of the code in your own words.**

```
//StreamWriter writes to a text file therefore when implimenting it, it must include the location of 
	the text file it's best to store the path and file name as private fields.
//When StreamWriter object is called it has to be closed. 
	Using the using statement is a dispose method that will close the streamwriter after it has 
	completed its function. 
	
using( StreamWriter sw = File.AppendText(_path + _file))
{
	sw.WriteLine($"{newMovie.Title} | {newMovie.Year} | {newMovie.Director} |{newMovie.Summary}");
}

//The AppendText method adds to the end of the text file rather than rewritting it.
//The WriteLine method used along with string interpolation writes the new line string to the end of
	the file. 

```
    

**3. What is the difference between a property and an auto implemented property? When would you use one over the other..**

	
Properties use accessors to get and set information while protecting the private fields they are accessing. 
Basic properties are materialized as methods but while getting and setting information they can also compute additional logic whereas, auto implemented properties dont handle addtional logic and just use the accessors to get and/or set information. If you dont need addtional logic, use auto properties; If you do, use the regular version.




**4. If a class member contains the keyword "static", how do you use this outside of the defining class?. Provide an example with an explanation.**  


```
//To access a static member from outside the class, the class name is used followed by the 
	dot operator.

    public static void Ball()
    {
        //Call Static function
        UI.BallColor();
    }
//The advantage of static members is that they can be used by other classes without having to 
	create an instance of the class.

```

<br>

# Reference Links
Replace the example references below with your own independent research. Do not use material already provided to you in this class. Two or more references are needed for each topic below.

**Working with Data**  
[Site Address](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)  

Along with the reading of Chapter 15: Properties of the C# Quick Syntax, I wanted a general definition of properties. I thought this helped when it came to getting a general understanding of it. I find it helpful when it comes to learning when I dont have a long reading and I can have key points to what it is without extra fluff. 


[Site Address](https://stackoverflow.com/questions/6001917/what-are-automatic-properties-in-c-sharp-and-what-is-their-purpose)  

This thread is helpful in explaining the differences between when and when not to use the different versions of auto-properties. It was nice to read about other peoples perspectives on the matter.


**Read and Write Data**  
[Site Address](https://docs.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=netcore-3.1)

This was helpful in reading over the different methods associated with the streamreader class like the Peek() which returns the next available charactor but doesn not comsume it.

[Site Address](https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=netcore-3.1)  

I thought this gave some very good examples and concise information on the different properties used with the stream writer.






