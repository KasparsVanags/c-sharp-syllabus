using System;

namespace DoWhileExample
{
    class Program
    {
        private static void Main(string[] args)
        {
            var i = 0;
            do {
                Console.WriteLine("CODELEX");
            } while (i == 1);
            // What will be the output?
            // 1. CODELEX
            //    CODELEX
            // 2. CODELEX
            // 3.  
            // 4. runtime error  
            // 5. compilation error
        }
    }
}