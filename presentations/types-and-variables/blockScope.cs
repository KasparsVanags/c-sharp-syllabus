// C# code to illustrate the Block 
// Level scope of variables 
using System; 

// declaring a Class 
class GFG 

{ // from here class level scope starts 

	// declaring a method 
	public void display() 

	{ // from here method level scope starts 

		// this variable has 
		// method level scope 
		int i = 0; 

		for (i = 0; i < 4; i++) { 

			// accessing method level variable 
			Console.WriteLine(i); 
		} 

		// here j is block level variable 
		// it is only accessible inside 
		// this for loop 
		for (int j = 0; j < 5; j++) { 
			// accessing block level variable 
			Console.WriteLine(j); 
		} 

		// this will give error as block level 
		// variable can't be accessed outside 
		// the block 
		Console.WriteLine(j); 

	} // here method level scope ends 

} // here class level scope ends 
