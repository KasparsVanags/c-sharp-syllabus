---?color=linear-gradient(to right, #4caf50, #dbff3d)
@title[Polymorphism]

@snap[midpoint announce-section-title text-white span-100]
Polymorphism
@snapend

+++
@title[Lesson objective]

@snap[north]
After this lesson you will know:
@snapend

@ul[list-bullets-black](false)
- What is a polymorphism
- Why do we need it
- What is an *abstract class* and *interface*
- Difference between "implements" and "extends" 

+++
@title[What is an polymorphism?]

@snap[north]
What is an polymorphism?
@snapend

@snap[midpoint span-80 fragment]
@quote[The dictionary definition of polymorphism refers to a principle in biology in which an organism or species can have many different forms or stages. This principle can also be applied to object-oriented programming and languages like the C#. Subclasses of a class can define their own unique behaviors and yet share some of the same functionality of the parent class.]
@snapend

+++
@title[What is an inheritance?]

@snap[north span-100]
What is an Inheritance?
@snapend

@snap[center]
It is the mechanism in c# by which one class is allow to inherit the features (fields and methods) of another class.
@snapend

+++?image=polymorphism/animals.png&size=auto 65%
@title[Animals]

+++?color=#1E1F21
@snap[midpoint span-100]
@code[java zoom-7](polymorphism/Animal.cs)
@snapend

+++?color=#1E1F21
@snap[midpoint span-100]
@code[java zoom-7](polymorphism/Bird.cs)
@snapend

+++?color=#1E1F21
@snap[midpoint span-100]
@code[java zoom-7](polymorphism/Eagle.cs)
@snapend

+++?color=#1E1F21
@snap[midpoint span-100]
@code[java zoom-7](polymorphism/Owl.cs)
@snapend

+++?color=#1E1F21
@snap[midpoint span-100]
@code[java zoom-7](polymorphism/CreateSomeAnimals.cs)
@snapend

+++
@title[Reusability]

@snap[north span-100]
Reusability
@snapend

@snap[center]
Facility to use public methods of base class without rewriting the same code over and over again.
@snapend

+++
@title[Extensibility]

@snap[north span-100]
Extensibility
@snapend

@snap[center]
Extending the base class logic as per business logic of the derived class.
@snapend

+++
@title[Data hiding]

@snap[north span-100]
Data hiding
@snapend

@snap[center]
Base class can decide to keep some data private so that it cannot be altered by the derived class.
@snapend

+++
@title[What is an interface?]

@snap[north span-100]
What is an Interface?
@snapend

@snap[center]
An interface is a programming structure/syntax that allows the computer to enforce certain properties on an object (class). It is very similar to an abstract class - but interface is purely abstract.
@snapend

+++
@title[Why to use interfaces?]

@snap[north span-100]
Why to use interfaces?
@snapend

@snap[center]
An interface is a contract (or a protocol, or a common understanding) of what the classes can do. 
When a class implements a certain interface, it promises to provide implementation to all the methods declared in the interface. 
@snapend

+++
@title[Methods in the interface]

@snap[north span-100]
Fields in the *interface*
@snapend

+++?color=#1E1F21
@title[Fields in the interface]

@snap[midpoint span-100]
@code[java zoom-10](polymorphism/ITaxable.cs)
@snapend

+++
@title[Interface naming]

@snap[north span-100]
Interface naming
@snapend

@ul[list-bullets-black](false)
- Interface is a type, good names are:
  - *ITruck*, *ICar*, *IHuman*, *IAnimal* etc.
<br/>
- Interface may describe a behaviour, good names are:
  - *ICloneable*, *IChargeable*, *IConsumable* etc. 
@ulend

+++
@title[Interfaces & abstract classes]

@snap[north span-100]
Interfaces & abstract classes
@snapend

@snap[center]
Remember: in C# class can extend only one class, but can implement multiple interfaces 
@snapend

+++?color=#1E1F21
@title[is]

@snap[midpoint span-100]
@code[java zoom-10](polymorphism/InstanceOfExample.cs)
@snapend

+++?color=linear-gradient(to top, #ffb347, #ffcc33)
@snap[midpoint announce-quiz text-white]
QUIZ
@snapend

+++
@title[Question #1]

@snap[center]
Can an interface ever contain method bodies?
@snapend
<br/>
@ol[list-bullets-black](false)
- No
- Yes
- Sometimes
- Always
@olend

+++?color=#1E1F21
@title[Question #2]

@snap[midpoint span-100]
@code[java zoom-10](polymorphism/Quiz2.cs)
@snapend

+++
@title[Question #3]

@snap[center]
Which statement is false?
@snapend
<br/>
@ol[list-bullets-black](false)
- class can extend only one class, but implement more than one interface
- class can implement only one interface, but extend more than one class
@olend

+++
@title[Question #4]

@snap[center]
Which statement is true if a child of an abstract parent class does **not** override all of the parent's abstract methods?
@snapend
<br/>
@ol[list-bullets-black](false)
- Compilation error occurs in a child class
- The child class itself must be declared to be abstract
- Child classes are automatically non-abstract, so everything will work
- Compilation error occurs in a parent class
@olend
