---?color=linear-gradient(to right, #4caf50, #dbff3d)
@title[program structure]

@snap[midpoint announce-section-title text-white span-100]
program structure
@snapend

+++
@title[Lesson objective]

@snap
After this lesson you will know:
@snapend

@ul[list-bullets-black](false)
- basic parts of a program.

+++
@title[Basic C# program]

@span[north]
A C# program consists of the following parts
@spanend

@ul[list-bullets-black](false)
- Namespace declaration
- A class
- Class methods
- Class attributes
- A Main method
- Statements and Expressions
- Comments
@ulend

+++
@title[Basic example]

@span[north]
Let us look at a simple code that prints the words "Hello World" 
@spanend
@span[north]
@code[c# zoom-12](program-structure/hello-world.cs)
@spanend

+++
@title[example result]

@span[north]
When this code is compiled and executed, it produces the following result
@spanend

@span[midpoint]
Hello World
@spanend

+++
@title[various parts of the program]

@ul[list-bullets-black](false)
- The first line of the program using System; - the using keyword is used to include the System namespace in the program. A program generally has multiple using statements.
- The next line has the namespace declaration. A namespace is a collection of classes. The HelloWorldApplication namespace contains the class HelloWorld.
- The next line has a class declaration, the class HelloWorld contains the data and method definitions that your program uses. 
- Classes generally contain multiple methods. Methods define the behavior of the class. However, the HelloWorld class has only one method Main.
- The next line defines the Main method, which is the entry point for all C# programs. The Main method states what the class does when executed.
- The next line /*...*/ is ignored by the compiler and it is put to add comments in the program.
- The Main method specifies its behavior with the statement Console.WriteLine("Hello World");
- WriteLine is a method of the Console class defined in the System namespace. 
- The last line Console.ReadKey(); is for the VS.NET Users.
@ulend

+++
@title[Compiling and executing]

@span[north]
If you are using Visual Studio.Net for compiling and executing C# programs, take the following steps
@spanend

@ul[list-bullets-black](flase)
- Start Visual Studio.
- On the menu bar, choose File -> New -> Project.
- Choose Visual C# from templates, and then choose Windows.
- Choose Console Application.
- Specify a name for your project and click OK button.
- This creates a new project in Solution Explorer.
- Write code in the Code Editor.
- Click the Run button or press F5 key to execute the project. A Command Prompt window appears that contains the line Hello World.
@ulend
