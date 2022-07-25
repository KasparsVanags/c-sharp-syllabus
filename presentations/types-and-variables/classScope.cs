// C# program to illustrate the 
// Class Level Scope of variables 
using System; 

// declaring a Class 
class GFG { // from here class level scope starts 

	// this is a class level variable 
	// having class level scope 
	int a = 10; 

	// declaring a method 
	public void display() 
	{ 
		// accessing class level variable 
		Console.WriteLine(a); 

	} // here method ends 

} // here class level scope ends 
