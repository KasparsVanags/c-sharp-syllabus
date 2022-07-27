using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var classesAndTeachers = new Dictionary<string, string>
            {
                {"English III", "Ms. Lapan"},
                {"Precalculus ", "Mrs. Gideon"},
                {"Music Theory", "Mr. Davis"},
                {"Biotechnology ", "Ms. Palmer"},
                {"Principles of Technology I", "Ms. Garcia"},
                {"Latin II", "Mrs. Barnett"},
                {"AP US History", "Ms. Johannessen"},
                {"Business Computer Infomation Systems", "Mr. James"},
            };
            
            Console.WriteLine("+" + new string('-', 54) + "+");
            for (var i = 0; i < classesAndTeachers.Count; i++)
            {
                var course = classesAndTeachers.ElementAt(i).Key;
                var teacher = classesAndTeachers.ElementAt(i).Value;
                var indexOfLine = i + 1;
                Console.WriteLine("|" + indexOfLine + "|" + course.PadLeft(36) + "|" + teacher.PadLeft(15) + "|");
            }
            
            Console.WriteLine("+" + new string('-', 54) + "+");
            Console.ReadKey();
        }
    }
}