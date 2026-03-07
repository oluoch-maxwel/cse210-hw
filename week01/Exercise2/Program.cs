using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your scored grade? ");
        string gradeStringFromStudent = Console.ReadLine();
        int grade = int.Parse(gradeStringFromStudent);

        int lastDigi = grade % 10;
        string gradeSign = "";

        if (lastDigi >= 7)
        {
            gradeSign = "+";
        }
        else if (lastDigi <= 3 )
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }


        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
             letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "B";
        }

        else 
        {    
            letter = "F";
        }

      Console.WriteLine($"Your grade is {letter}{gradeSign}");
    }
}