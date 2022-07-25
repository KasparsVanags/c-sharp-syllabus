---?color=linear-gradient(to right, #4caf50, #dbff3d)
@title[Operators]

@snap[midpoint announce-section-title text-white span-100]
Operators
@snapend

+++
@title[Lesson objective]

@snap[north span-100]
After this lesson you will know:
@snapend
<br/>
@ul[list-bullets-black](false)
- What are and how to apply: 
  - arithmetic operators
  - comparison operators
  - boolean operators
  - arithmetic compound operators
- In which order arithmetic operations are being executed
@ulend

+++
@title[Arithmetic operators]

@snap[north]
Arithmetic operators
@snapend

| Name | Meaning | Example | Result |
| --- | --- | --- | --- |
| ```+``` | Addition | ```4 + 3``` | ```7``` | 
| ```-``` | Subtraction | ```9 - 4``` | ```5``` | 
| ```*``` | Multiplication | ```2 * 6``` | ```12``` | 
| ```/``` | Division | ```9 / 3``` | ```3``` | 
| ```%``` | Remainder | ```20 % 3``` | ```2``` |

@snap[south span-100]
@css[text-orange](Integer division throws away reminder)
@snapend

Note:

/ is the division operator. If the types of the operands are double, then "real" division is performed. Real division is normal division. Division is approximate on a computer because you can't do infinitely precise division (recall that double values have finite precision, so there is usually a tiny, but unavoidable error representing real numbers). The result of dividing a double by a double is a double.
However, if both expressions have type int, then the result is an int.

C# does integer division, which basically is the same as regular real division, but you throw away the remainder (or fraction). Thus, 7 / 3 is 2 with a remainder of 1. Throw away the remainder, and the result is 2.

+++
@title[Rational operators]

@snap[north]
Rational operators
@snapend

| C# operator | Mathematics symbol |
| --- | --- |
| ```<``` | ```<``` |
| ```<=``` | ```≤``` |
| ```>``` | ```>``` |
| ```>=``` | ```≥``` |
| ```==``` | ```=``` |
| ```!=``` | ```≠``` |

Note:

Note that the equality operator is double equality sign (==), not single equality sign (=).

+++
@title[Logical operators]

@snap[north]
Logical operators
@snapend

| Operator | Name | Description |
| --- | --- | --- |
| ! | not | logical negation |
| && | and | logical conjunction |
| &#124;&#124; | or | logical disjunction |
| ^ | exclusive or | [logical exclusion](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators#logical-exclusive-or-operator-) |

Note:

^ - More simply, you can also think of xor as "this or that, but not both!".

+++
@title[Truth table]

@snap[north]
Truth table
@snapend

| x | y | !x | x && y | x &#124;&#124; y | x ^ y |
| --- | --- | --- | --- | --- | --- |
| true | true | false | true | true | false |
| true | false | false | false | true | true |
| false | true | true | false | true | true |
| false | false | true | false | false | false |

+++
@title[Arithmetic compound operators]

@snap[north span-100]
Arithmetic compound operators
@snapend

| Operator | Description |
| --- | --- |
| ++ | Increment |
| += | Addition assignment |
| -- | Decrement |
| -= | Subtraction assignment |
| *= | Multiplication assignment |
| /= | Division assignment |
| %= | Modulus assignment |

+++?color=#1E1F21
@title[Example #1]

@snap[north span-100]
Example
@snapend

@snap[midpoint]
@code[c# zoom-12](operators/Example1.cs)
@snapend

+++?color=#1E1F21
@title[++x vs x++]

@snap[north span-100]
++x vs x++
@snapend

@snap[midpoint]
@code[c# zoom-12](operators/Example2.cs)
@snapend

+++?image=operators/operator-precedence.jpg&size=auto 75%
@title[Operator precedence]

@snap[north span-100]
Operator precedence
@snapend

+++
@title[Math methods]

@snap[north span-100]
Math methods
@snapend

| Method | Description |
| --- | --- |
| Math.Abs() | Absolute value |
| Math.Round() | Rounding |
| ... | ... |

@snap[south span-100]
[System.Math](https://docs.microsoft.com/en-us/dotnet/api/system.math?view=netframework-4.8) provides methods for mathematical operations 
@snapend

+++?color=linear-gradient(to top, #ffb347, #ffcc33)
@title[Quiz]

@snap[midpoint announce-quiz text-white]
QUIZ
@snapend

+++?color=#1E1F21
@title[Question #1]

@snap[midpoint]
@code[c# zoom-15](operators/Question1.cs)
@snapend

+++?color=#1E1F21
@title[Question #2]

@snap[midpoint]
@code[c# zoom-15](operators/Question2.cs)
@snapend

+++?color=#1E1F21
@title[Question #3]

@snap[midpoint]
@code[c# zoom-15](operators/Question3.cs)
@snapend

+++?color=#1E1F21
@title[Question #4]

@snap[midpoint]
@code[c# zoom-15](operators/PrePostIncrement.cs)
@snapend

+++
@title[Must read]

@snap[span-100 text-center]
*C# Programming Yellow Book*
@snapend
@ul[list-bullets-black span-100](false)
- Giving Values to Variables [Chapter 2.2.6]
- Controlling Program Flow  [Chapter 2.3.2]
@ulend

<br/>

@snap[span-100 text-center]
*C# Notes for Professionals*
@snapend
@ul[list-bullets-black span-100](false)
- Operators [Chapter 3]
@ulend
