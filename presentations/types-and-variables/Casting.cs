// C# program to demonstrate the 
// Built- In Type Conversion Methods 
using System; 
namespace Casting{ 

class GFG { 

		// Main Method 
		public static void Main(String []args) 
		{ 
			int i = 12; 
			double d = 765.12; 
			float f = 56.123F; 
			
			// Using Built- In Type Conversion 
			// Methods & Displaying Result 
			Console.WriteLine(Convert.ToString(f)); 
			Console.WriteLine(Convert.ToInt32(d)); 
			Console.WriteLine(Convert.ToUInt32(f)); 
			Console.WriteLine(Convert.ToDouble(i)); 
		} 
} 
} 
