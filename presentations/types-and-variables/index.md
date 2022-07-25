---?color=linear-gradient(to right, #4caf50, #dbff3d)
@title[Types & Variables]

@snap[midpoint announce-section-title text-white span-100]
Types & Variables
@snapend

+++
@title[Lesson objective]

@snap[span-100]
After this lesson you will know:
@snapend
<br/>
@ul[list-bullets-black](false)
- Why are types needed
- Primitive data types
- How to work with *String*
- What is a variable and scope
- How to name variables
- How variables are stored in the memory
- What is type casting
- What is **null**
@ulend

+++?image=.gitpitch/img/bg/black.jpg&position=right&size=50% 100%
@title[Static and dynamic typing]

@snap[north-west span-40 text-center]
Static typing
@snapend

@snap[west span-40]
@code[c# zoom-12](types-and-variables/types.cs)
@snapend

@snap[west span-45 text-08]
@box[bg-green text-white fragment](More errors detected earlier in development.)
<br/>
@box[bg-green text-white fragment](Allows for compiler optimisation which yields faster code.)
<br/>
@box[bg-orange text-white fragment](Can lead to boilerplate.) 
@snapend

@snap[north-east span-40 text-center text-white]
Dynamic typing
@snapend

@snap[east span-40]
@code[python zoom-12](types-and-variables/types.py)
@snapend

@snap[east span-45 text-08 text-white]
@box[bg-green text-white fragment](Less boilerplate for a self describing data.)
<br/>
@box[bg-orange text-white fragment](More errors detected later in development and in maintenance.)
<br/>
@box[bg-orange text-white fragment](Tends to prohibit compilation and yields poor performing code.)
@snapend

+++?image=types-and-variables/types-diagram.jpg&size=auto 90%
@title[Types]

+++
@title[Integers]

@snap[north]
Integers
@snapend

| Name | Width | Range |
| --- | --- | --- |
| long | 64 | -9 223 372 036 854 775 808 to +9 223 372 036 854 775 807 |
| int | 32 | -2 147 483 648 to +2 147 483 647 |
| short | 16 | -32 768 to +32 767 |
| byte | 8 | -128 to +127 |

@ul[list-bullets-black](false)
- The most commonly used integer type is *int*.
- If the integer values are larger than its feasible range, then an @css[text-orange](overflow) occurs.
@ulend

+++
@title[Floating point numbers]

@snap[north]
Floating point numbers
@snapend

| Name | Width | Approximate |
| --- | --- | --- |
| double | 64 | 4.9e-324 to 1.8e+308 |
| float | 32 | 1.4e-045 to 3.4e+038 |

@ul[list-bullets-black](false)
- Floats are used when evaluating expressions that require fractional precision.
- Be aware that floating-point arithmetic can only approximate real arithmetic. See [0.30000000000000004.com](https://0.30000000000000004.com).
@ulend

+++
@title[Boolean]

@snap[north]
Boolean
@snapend

@ul[list-bullets-black](false)
- The program is supposed to do decision making by itself.
- To do this, C# has the boolean-type flow controls (selections and iterations).
- This type has only two possible values, *true* and *false*.
@ulend

+++
@title[Char]

@snap[north]
Char
@snapend

@ul[list-bullets-black](false)
- A character stored by the machine is represented by a sequence of 0’s and 1’s.
- The char type is a 16-bit unsigned primitive data type.
- C# uses Unicode to represent characters. Unicode defines a fully international character set that can represent all of the characters found in all human languages.
@ulend

+++?color=#1E1F21
@title[String]

@snap[north span-100]
*String* [[documentation](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)]
@snapend

@snap[midpoint]
@code[c# zoom-10](types-and-variables/strings.cs)
@snapend

+++?color=#1E1F21
@title[String concatenation]

@snap[north span-100]
String concatenation
@snapend

@snap[midpoint span-80]
@code[c# zoom-12](types-and-variables/stringConcatenation.cs)
@snapend

+++?color=#1E1F21
@title[String immutability]

@snap[north span-100]
String immutability
@snapend

@snap[midpoint span-80]
@code[c# zoom-10](types-and-variables/stringImmutability.cs)
@snapend

@snap[midpoint span-100 text-12]
@box[bg-orange text-white fragment](Once created *String* cannot be changed)
<br/>
@box[bg-orange text-white fragment](If String method returns String - although it may look similar but it is a new object)
@snapend

+++?image=types-and-variables/box.jpg&size=auto 50%
@title[Comparison]

@snap[south text-18]
Variable ≈ Box
@snapend

+++
@title[How to declare a variable?]

@snap[north]
Variable Declaration
@snapend

@ul[list-bullets-black](false)
- Give it a name, for example *x*.
- Assign a type.
- For example ```int x = 10;```
- Variable declaration tells the compiler to allocate appropriate memory space for the variable based on its data type. 
@ulend

+++
@title[How variables are stored in memory?]

@snap[north]
How variables are stored in memory?
@snapend

@snap[midpoint img-w-40 img-pt-3]
![memory](types-and-variables/variables-in-memory.png)
@snapend

+++
@title[How variables are stored in memory?]

@snap[north]
How variables are stored in memory?
@snapend

@ul[midpoint list-bullets-black span-100](false)
- The number *0x000abc26* stands for one memory address in [hexadecimal](https://en.wikipedia.org/wiki/Hexadecimal) (0-9, and a-f).
- The variable *x* itself refers to *0x000abc26* in the program after compilation.
@ulend

Note:

In mathematics and computing, hexadecimal (also base 16, or hex) is a positional numeral system with a radix, or base, of 16. It uses sixteen distinct symbols, most often the symbols "0"–"9" to represent values zero to nine, and "A"–"F" (or alternatively "a"–"f") to represent values ten to fifteen.

Hexadecimal numerals are widely used by computer system designers and programmers, as they provide a more human-friendly representation of binary-coded values.

+++
@title[Two "Before" rules]

@snap[north]
Two "Before" rules
@snapend

@ul[list-bullets-black](false)
- @css[text-orange](A declared variable must have a value assigned before it can be used.)
- @css[text-orange](A variable must be declared before it can have a value assigned.)
  - In practice, do not declare the variable until you need it.
@ulend

+++
@title[null]

@snap[north]
What if there is no value?
@snapend

@ul[list-bullets-black](false)
- If there is no memory allocated for the variable it is **null**.
- Primitive types cannot be **null**.
@ulend

Note:

Recall box, it is when there is nothing in the box.

+++?color=#1E1F21
@title[Example]

@snap[midpoint span-80]
@code[c# zoom-12](types-and-variables/nullExample.cs)
@snapend

+++
@title[Variable scope]

@snap[north]
Variable scope
@snapend

@ul[list-bullets-black](false)
- @css[text-orange](Class) Level Scope
- @css[text-orange](Method) Level Scope
- @css[text-orange](Block) Level Scope
@ulend

+++
@title[Variable scope - Class]

@snap[north span-100]
Class Level Scope
@snapend
@ul[list-bullets-black text-08](false)
 - Declaring the variables in a class but outside any method can be directly accessed anywhere in the class.
 - These variables are also termed as the fields or class members.
 - Class level scoped variable can be accessed by the non-static methods of the class in which it is declared.
 - Access modifier of class level variables doesn’t affect their scope within a class.
 - Member variables can also be accessed outside the class by using the access modifiers.
@ulend

+++?color=#1E1F21
@title[Variable scope - Class Example]

@snap[midpoint span-80]
@code[c# zoom-08](types-and-variables/classScope.cs)
@snapend

+++
@title[Variable scope - Method]

@snap[north span-100]
Method Level Scope
@snapend
@ul[list-bullets-black text-08](false)
 - Variables that are declared inside a method have method level scope. These are not accessible outside the method.
 - However, these variables can be accessed by the nested code blocks inside a method.
 - These variables are termed as the local variables.
 - There will be a compile-time error if these variables are declared twice with the same name in the same scope.
 - These variables don’t exist after method’s execution is over.
@ulend

+++?color=#1E1F21
@title[Variable scope - Method Example]

@snap[midpoint span-80]
@code[c# zoom-05](types-and-variables/methodScope.cs)
@snapend

+++
@title[Variable scope - Block ]

@snap[north span-100]
Block Level Scope
@snapend
@ul[list-bullets-black text-08](false)[span-100]
 - These variables are generally declared inside the for, while statement etc.
 - These variables are also termed as the loop variables or statements variable as they have limited their scope up to the body of the statement in which it declared.
 - Generally, a loop inside a method has three level of nested code blocks(i.e. class level, method level, loop level).
 - The variable which is declared outside the loop is also accessible within the nested loops. It means a class level variable will be accessible to the methods and all loops. Method level variable will be accessible to loop and method inside that method.
 - A variable which is declared inside a loop body will not be visible to the outside of loop body.
@ulend

+++?color=#1E1F21
@title[Variable scope - Block Example]

@snap[midpoint span-80]
@code[c# zoom-04](types-and-variables/blockScope.cs)
@snapend

+++
@title[Naming rules]

@snap[north]
Naming rules
@snapend

@ul[list-bullets-black](false)
- Identifiers are the names that identify the elements such as **variables**, **methods**, and **classes** in the program.
- The naming rule excludes the following situations:
  - @css[text-orange](cannot start with a digit)
  - @css[text-orange](cannot be any [reserved word](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/))
  - @css[text-orange](cannot include any blank between letters)
  - @css[text-orange](cannot contain +, -, ∗, / and %)
  - C# is @css[text-orange](case sensitive).
@ulend

+++
@title[Type Conversion and Compatibility]

@snap[north span-100]
Type Conversion and Compatibility
@snapend
<br/>
@ul[list-bullets-black text-08](false)
- Type conversion happens when we assign the value of one data type to another. 
- If the data types are @css[text-orange](compatible), then C# does Automatic Type Conversion. 
- If not comparable, then they need to be converted @css[text-orange](explicitly) which is known as Explicit Type conversion. 
- For example, assigning an int value to a long variable.
- For example, the integer 1 is compatible to a double value 1.0.
- However, there is no automatic conversion from double to int. (Why?)
@ulend
+++

@title[Lossy Conversion]

@snap[north span-100]
Lossy Conversion
@snapend

@ul[list-bullets-black](false)
- if we want to assign a value of larger data type to a smaller data type we perform explicit type casting.
- This is useful for incompatible data types where automatic conversion cannot be done.(double to int)
- Here, target-type specifies the desired type to convert the specified value to.
- Sometimes, it may result into the @css[text-orange](lossy conversion).
@ulend

+++?color=#1E1F21
@title[Lossy Conversion - example]

@snap[north span-100]
Lossy Conversion
@snapend

@snap[midpoint span-80]
@code[c# zoom-07](types-and-variables/lossyConversion.cs)
@snapend

@snap[south span-100]
@css[text-orange](Explanation:)
Here due to lossy conversion, the value of i becomes 765 and there is a loss of 0.12 value.
@snapend

+++
@title[Casting]

@snap[north span-100]
Casting
@snapend
<br/>
@snap[span-100]
C# provides **built-in** methods for Type-Conversions.
@snapend

+++
@title[Built-in casting]

@snap[north span-100]
Built-in casting
@snapend
<br/>
@ul[list-bullets-black text-08](false)
- **ToBoolean**
- **ToChar**
- **ToByte**
- **ToDecimal**
- **ToDouble**
- **ToInt16**
- **ToInt32**
- **ToInt64**
- **ToString**
- **ToUInt16**
- **ToUInt32**
- **ToUInt64**
@ulend

+++?color=#1E1F21
@title[Casting example]

@snap[midpoint span-80]
@code[c# zoom-08](types-and-variables/Casting.cs)
@snapend

+++
@title[Type Checking]

@snap[north span-100]
Type Checking
@snapend
<br/>
@ul[list-bullets-black](false)
- Note that the C# compiler does only @css[text-orange](type-checking) but no real execution before compilation.
- In other words, the values of variables are unknown until they are really executed.
@ulend

+++?color=linear-gradient(to top, #ffb347, #ffcc33)
@title[Quiz]

@snap[midpoint announce-quiz text-white]
QUIZ
@snapend

+++?color=#1E1F21
@title[Question #1]

@snap[midpoint]
@code[c# zoom-10](types-and-variables/Floats.cs)
@snapend

+++
@title[Question #2]

@snap[span-100]
In which of the following answers does the number of bits increase from fewest to most?
@snapend

@ol[list-bullets-black](false)
- byte < long < short < int
- int < byte < short < long
- byte < short < int < long
- short < byte < long < int
@olend

+++?color=#1E1F21
@title[Question #3]

@snap[midpoint span-80]
@code[c# zoom-10](types-and-variables/Question1.cs)
@snapend

+++?color=#1E1F21
@title[Question #4]

@snap[midpoint span-80]
@code[c# zoom-10](types-and-variables/Question2.cs)
@snapend

+++
@title[Question #5]

@snap[north]
Which of these statements are true?
@snapend

@ol[list-bullets-black](false)
- null can be any type, including primitive types
- primitive - *int*, object - Integer
- null can be any type, excluding primitive types
- primitive - *Integer*, object - int
@olend

+++
@title[Must read]

@snap[span-100 text-center]
*C# Programming Yellow Book*
@snapend
@ul[list-bullets-black span-100](false)
- Variables and Scope [Chapter 3.2]
@ulend

<br/>

@snap[span-100 text-center]
*C# Notes for Professionals*
@snapend
@ul[list-bullets-black span-100](false)
- Literals [Chapter 18]
- Built-in Types [Chapter 32]
- Type Conversion [Chapter 36]
- Casting [Chapter 37]
@ulend

+++
@title[Further reading]

@snap[span-100]
Further reading and tutorials:
@snapend
<br/>
@ul[list-bullets-black](false)
- [Data types](http://zetcode.com/lang/csharp/datatypes/)
- [Static vs dynamic typing](https://hackernoon.com/i-finally-understand-static-vs-dynamic-typing-and-you-will-too-ad0c2bd0acc7)
- [Why String is Immutable in C#?](https://www.c-sharpcorner.com/article/why-string-is-immutable/)
- [Primitives vs objects](http://www.jeremyshanks.com/c-variables-primitive-nonprimitive-types/)
@ulend