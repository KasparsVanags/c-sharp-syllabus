---?color=linear-gradient(to right, #4caf50, #dbff3d)
@title[Classes and objects]

@snap[midpoint announce-section-title text-white span-100]
Classes and Objects
@snapend

+++
@title[Lesson Objective]

@snap[north span-100]
Lesson Objective
@snapend

@ul[list-bullets-black](false)
- [*Class*](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes)
- [*Object*](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/objects) and *instance*
- [*Method*](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)
- [**static**](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static)
- [**constructor**](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)
- [**this**](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this)
@ulend

+++
@title[What is a Class?]

@snap[north span-100]
What is a Class?
@snapend

@snap[midpoint span-80]
A class, in the context of C#, are **prototypes** / **templates** that are used to create objects. 
@snapend

+++?color=#1E1F21
@title[Class]

@snap[midpoint span-80]
@code[c# zoom-10](classes-and-objects/src/what-is-class.cs)
@snapend

+++
@title[What is a Method?]

@snap[north span-100]
What is a Method?
@snapend

@snap[midpoint span-80]
A C# method is a collection of instructions that are grouped together to perform an operation.
@snapend

+++?color=#1E1F21
@title[Method]

@snap[midpoint span-80]
@code[c# zoom-05](classes-and-objects/src/what-is-method.cs)
@snapend

+++
@title[What is Constructor?]

@snap[north span-100]
What is Constructor?
@snapend

@snap[midpoint span-75]
Constructor is a special method which is invoked when we initialize object instance. If no constructor is defined default no arg constructor is generated.
@snapend

+++
@title[Constructor]

@snap[north span-100]
C# allows two types of constructors
@snapend

@ul[list-bullets-black](false)
- No argument Constructors
- Parameterized Constructors
@ulend

+++?color=#1E1F21
@title[Constructor]

@snap[midpoint span-80]
@code[c# zoom-05](classes-and-objects/src/what-is-constructor.cs)
@snapend

+++
@title[What is an Object?]

@snap[north span-100]
What is an Object?
@snapend

@snap[midpoint span-80]
Object refers to a particular instance of a class, where the object can be a combination of variables, functions, and data structures.
In C# object is a direct or indirect base of every data type.
@snapend

+++?image=classes-and-objects/img/class-object.png&size=auto 40%
@title[Class and object example]

+++?color=#1E1F21
@title[Class Instance]

@snap[midpoint]
@code[c# zoom-10](classes-and-objects/src/what-is-object-instance.cs)
@snapend

+++
@title[static]

@snap[north span-100]
**static**
@snapend

@ul[list-bullets-black](false)
- means that field/method
  - is @css[text-orange](defined for the class declaration)
  - is @css[text-orange](not) unique
@ulend

+++?color=#1E1F21
@title[Example]

@snap[midpoint span-75]
@code[c# zoom-07](classes-and-objects/src/what-is-static.cs)
@snapend

+++
@title[Static variable initialization]

@snap[north span-100]
Static variables are initialized
@snapend

@ol[list-bullets-black](false) 
- When class is loaded
- Before any object of that class is created
- Before any static method of the class executes
@olend

+++
@title[this]

@snap[north span-100]
**this**
@snapend

@snap[midpoint span-75]
@ul[list-bullets-black](false)
- can be used inside a constructor or @css[text-orange](instance method)
- **this** works as a reference to the current Object, whose Method or constructor is being invoked
@ulend
@snapend

+++?color=#1E1F21
@title[Example]

@snap[midpoint]
@code[c# zoom-07](classes-and-objects/src/what-is-this.cs)
@snapend

+++
@title[this & static]

@snap[north span-100]
**this** & **static**
@snapend

@snap[midpoint span-100 text-20]
@box[bg-orange text-white fragment](**Remember:** there is no **this** available in a **static** context, because there is no instance present)
@snapend

+++
@title[When to use static?]

@snap[north span-100]
When to use **static**?
@snapend

@snap[midpoint span-75 fragment]
One rule-of-thumb: ask yourself **does it make sense to call this method, even if no Object has been constructed yet?** 
If so, it should definitely be static.
@snapend

+++?color=linear-gradient(to top, #ffb347, #ffcc33)
@title[Quiz]

@snap[midpoint announce-quiz text-white]
QUIZ
@snapend

+++?color=#1E1F21
@title[Question #1]

@snap[midpoint span-100]
@code[cs zoom-07](classes-and-objects/src/quiz-static.cs)
@snapend

+++
@title[Question #2]

@snap[north span-100]
Which statements are false?
@snapend

@ol[list-bullets-black](false)
- class is like a blueprint, but instance is an object based on this blueprint
- instance is like a blueprint, but class is an object based on this blueprint
- instance variables can be accessed from a static context
- class variables can be accessed from an instance context
@olend

+++
@title[Question #3]

@snap[north span-100]
Which of these applies to static?
@snapend

@ol[list-bullets-black](false)
- is unique for each instance
- it not unique for each instance
- this is accessible in a static context
- this is not accessible in a static context
- once static field is changed all instances see the change
- once static field is changed only current instance see the change
@olend

+++
@title[Must read]

@snap[span-100 text-center]
*C# Programming Yellow Book*
@snapend
@ul[list-bullets-black span-100](false)
- Designing With Objects [Chapter 4.5]
- Static Items [Chapter 4.6]
- The Construction of Objects [Chapter 4.7]
@ulend

<br/>

@snap[span-100 text-center]
*C# Notes for Professionals*
@snapend
@ul[list-bullets-black span-100](false)
- Constructors and Finalizers [Chapter 39]
@ulend

<br/>

@snap[span-100 text-center]
*Documentation*
@snapend
@ul[list-bullets-black span-100](false)
- [Classes & Structs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/)
@ulend