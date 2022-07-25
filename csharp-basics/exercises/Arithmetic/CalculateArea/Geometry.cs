using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(double radius)
        {
            if (radius > 0)
            {
                return Math.PI * radius * 2;
            }
            
            Console.WriteLine("Radius must be higher than 0.");
            return 0;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            if (length > 0 && width > 0)
            {
                return length * width;
            }
            
            Console.WriteLine("Length and width must be higher than 0.");
            return 0;
        }

        public static double AreaOfTriangle(double bottom, double height)
        {
            if (bottom > 0 && height > 0)
            {
                return bottom * height * 0.5;
            }
            
            Console.WriteLine("Base and height must be higher than 0.");
            return 0;
        }
    }
}
