using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMenu();
        }

        public static void GetMenu()
        {
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
                
            var input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case '1':
                    CalculateCircleArea();
                    break;
                case '2':
                    CalculateRectangleArea();
                    break;
                case '3':
                    CalculateTriangleArea();
                    break;
                case '4':
                    return;
                default:
                    Console.WriteLine("\nInvalid Input");
                    GetMenu();
                    break;
                }
        }

        public static void CalculateCircleArea()
        {
            while (true)
            {
                Console.WriteLine("\nEnter the circle's radius and press Enter ");
                if (int.TryParse(Console.ReadLine(), out int radius))
                {
                    Console.WriteLine("Radius: " + radius);
                    Console.WriteLine("The circle's area is " + Geometry.AreaOfCircle(radius));
                    GetMenu();
                    return;
                }

                Console.WriteLine("Error. You must input a number.");
            }
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine("\nEnter length and press Enter ");
            if (double.TryParse(Console.ReadLine(), out double length))
            {
                Console.WriteLine("Length: " + length);
            }
            else
            {
                Console.WriteLine("Error. You must input a number.");
                CalculateRectangleArea();
                return;
            }

            Console.WriteLine("Enter width and press Enter ");
            if (double.TryParse(Console.ReadLine(), out double width))
            {
                Console.WriteLine("Width: " + width);
            }
            else
            {
                Console.WriteLine("Error. You must input a number.");
                CalculateRectangleArea();
                return;
            }

            Console.WriteLine("The rectangle's area is " + Geometry.AreaOfRectangle(length, width));
            GetMenu();
        }

        public static void CalculateTriangleArea()
        {
            Console.WriteLine("\nEnter base and press Enter ");
            if (double.TryParse(Console.ReadLine(), out double bottom))
            {
                Console.WriteLine("Base: " + bottom);
            }
            else
            {
                Console.WriteLine("Error. You must input a number.");
                CalculateTriangleArea();
                return;
            }

            Console.WriteLine("Enter height and press Enter ");
            if (double.TryParse(Console.ReadLine(), out double height))
            {
                Console.WriteLine("Width: " + height);
            }
            else
            {
                Console.WriteLine("Error. You must input a number.");
                CalculateTriangleArea();
                return;
            }

            Console.WriteLine("The triangle's area is " + Geometry.AreaOfTriangle(bottom, height));
            GetMenu();
        }
    }
}
