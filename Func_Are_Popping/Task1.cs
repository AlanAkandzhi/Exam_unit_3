using System;
using System.Collections.Generic;

namespace YourNamespace
{
    public static class MathOperations
    {
        public static double Square(double number) => number * number;
        public static double Cube(double number) => number * number * number;
        
        public static double SquareRoot(double number)
        {
    if (number < 0) throw new ArgumentOutOfRangeException(nameof(number));
    return Math.Sqrt(number);
     }

    }
    

    public static class MeasurementConverter
    {
        public static double InchesToMillimeters(double inches)
        {
            return inches * 25.4;
        }
    }

    public static class CircleCalculator
    {
        public static double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
    }

    public static class GreetingGenerator
    {
        private static readonly List<string> names = new List<string> { "Tony", "Rune", "Christian", "Tobias", "Mark" };
        private static readonly Random random = new Random();

        public static string GreetRandom()
        {
            int index = random.Next(names.Count);
            return $"Hello, {names[index]}!";
        }
    }
    
      public class Task1
    {
        public static void Main(string[] args)
        {
            
            if (args.Length > 0 && args[0] == "test")
            {
                
                Test1.RunAllTests();
            }
            else
            {
                
                double number = 9;
                Console.WriteLine($"Square: {MathOperations.Square(number)}, Cube: {MathOperations.Cube(number)}, SquareRoot: {MathOperations.SquareRoot(number)}");
                double inches = 1;
                double millimeters = MeasurementConverter.InchesToMillimeters(inches);
                Console.WriteLine($"{inches} inch is {millimeters} millimeters.");
                double radius = 5;
                double area = CircleCalculator.Area(radius);
                Console.WriteLine($"The area of a circle with a radius of {radius} is {area}.");
                string greeting = GreetingGenerator.GreetRandom();
                Console.WriteLine(greeting);
            }
        }
    }
}
