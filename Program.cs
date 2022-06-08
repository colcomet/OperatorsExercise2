using System;

namespace OperatorsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{4} is {quotient} remainder {remainder}");
            Console.WriteLine();

            //Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
        }

        public static double AreaOfCircle(double radius)
        {
            return (Math.PI * radius * radius);
        }
    }
}
