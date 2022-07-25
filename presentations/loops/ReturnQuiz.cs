using System;

namespace ReturnQuiz
{
    class Program
    {
        private static void Main(string[] args)
        {
            for (var i = 0; i < 3; i++) {
                if (i == 1) {
                    Console.Write("Bye!");
                    return;
                }
                Console.Write("Currently @" + i + ", ");
            }
            // What will be the output?
            // 1. Currently @0, Currently @1, Currently @2, Bye!
            // 2. Currently @0, Currently @1, Bye!
            // 3. Currently @0, Bye!
            // 4. Currently @0, Currently @1, Bye! Currently @2, 
            // 5. runtime error 
            // 6. compilation error 
        }
    }
}