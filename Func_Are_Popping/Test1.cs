using System;
using Task1;


public class Test1
{
    public static void RunAllTests()
    {
        TestSquare();
        TestCube();
        TestSquareRoot();
        TestInchesToMillimeters();
        TestArea();
        TestGreetRandom();
    }

    private static void TestSquare()
    {
        double input = 9;
        double expected = 81;
        double result = MathOperations.Square(input);
        Console.WriteLine($"Test Square: Expected={expected}, Result={result}, Passed={result == expected}");
    }

    private static void TestCube()
    {
        double input = 3;
        double expected = 27;
        double result = MathOperations.Cube(input);
        Console.WriteLine($"Test Cube: Expected={expected}, Result={result}, Passed={result == expected}");
    }

    private static void TestSquareRoot()
    {
        double input = 9;
        double expected = 3;
        double result = MathOperations.SquareRoot(input);
        Console.WriteLine($"Test SquareRoot: Expected={expected}, Result={result}, Passed={Math.Abs(result - expected) < 0.0001}");
    }

    private static void TestInchesToMillimeters()
    {
        double input = 1;
        double expected = 25.4;
        double result = MeasurementConverter.InchesToMillimeters(input);
        Console.WriteLine($"Test InchesToMillimeters: Expected={expected}, Result={result}, Passed={Math.Abs(result - expected) < 0.0001}");
    }

    private static void TestArea()
    {
        double input = 1;
        double expected = Math.PI;
        double result = CircleCalculator.Area(input);
        Console.WriteLine($"Test Area: Expected={expected}, Result={result}, Passed={Math.Abs(result - expected) < 0.0001}");
    }

    private static void TestGreetRandom()
    {
        string result = GreetingGenerator.GreetRandom();
        Console.WriteLine($"Test GreetRandom: Result={result}, Passed={!string.IsNullOrEmpty(result)}");
    }
}