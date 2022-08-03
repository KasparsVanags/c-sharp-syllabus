using System;

namespace Exercise6
{
    internal class DogTest
    {
        public static void Main(string[] args)
        {
            var max = new Dog("Max", "male");
            var rocky = new Dog("Rocky", "male");
            var sparky = new Dog("Sparky", "male");
            var buster = new Dog("Buster", "male");
            var sam = new Dog("Sam", "male");
            var lady = new Dog("Lady", "female");
            var molly = new Dog("Molly", "female");
            var coco = new Dog("Coco", "female");
            
            max.Father = rocky;
            max.Mother = lady;
            coco.Father = buster;
            coco.Mother = molly;
            rocky.Father = sam;
            rocky.Mother = molly;
            buster.Father = sparky;
            buster.Mother = lady;
            
            Console.WriteLine("Coco's fathers name: " + coco.FathersName());
            Console.WriteLine("Sparky's fathers name: " + sparky.FathersName());
            Console.WriteLine("Coco and Rocky have the same mother?: " + coco.HasSameMotherAs(rocky));
            Console.ReadKey();
        }
    }
}