using System;

namespace Exercise12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var paper1 = new Testpaper("Maths", new [] { "1A", "2C", "3D", "4A", "5A" }, "60%");
            var paper2 = new Testpaper("Chemistry", new [] { "1C", "2C", "3D", "4A" }, "75%");
            var paper3 = new Testpaper("Computing", new [] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");
            var student1 = new Student();
            var student2 = new Student();
            Console.WriteLine("Student 1, no tests taken:");
            ListTests(student1);
            Console.WriteLine("Student 1 passed Maths test:");
            student1.TakeTest(paper1, new [] { "1A", "2D", "3D", "4A", "5A" });
            ListTests(student1);
            Console.WriteLine("Student 2 failed everything:");
            student2.TakeTest(paper2, new []{ "1C", "2D", "3A", "4C" });
            student2.TakeTest(paper3, new []{ "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
            ListTests(student2);
            Console.ReadKey();

            void ListTests(IStudent student)
            {
                if (student.TestsTaken.Length == 0)
                {
                    Console.WriteLine("No tests taken");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", student.TestsTaken));
                }
            }
        }
    }
}