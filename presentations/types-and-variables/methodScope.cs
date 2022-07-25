// C# program to illustrate the 
// Method Level Scope of variables 
using System; 

// declaring a Class 
class GFG { // from here class level scope starts 

	// declaring a method 
	public void display() 

	{ // from here method level scope starts 

		// this variable has 
		// method level scope 
		int m = 47; 

		// accessing method level variable 
		Console.WriteLine(m); 

	} // here method level scope ends 

	// declaring a method 
	public void display1() 

	{ // from here method level scope starts 

		// it will give compile time error as 
		// you are trying to access the local 
		// variable of method display() 
		Console.WriteLine(m); 

	} // here method level scope ends 

} // here class level scope ends 
