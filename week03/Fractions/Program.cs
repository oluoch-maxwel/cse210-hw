using System;

class Program
{
    static void Main(string[] args)
    {
        // Default constructor
        Fraction function1 = new Fraction();

        // One-parameter constructor
        Fraction function2 = new Fraction(5);

        // Two-parameter constructor
        Fraction function3 = new Fraction(2, 3);

        function1.Display();
        function2.Display();
        function3.Display();
    }
}