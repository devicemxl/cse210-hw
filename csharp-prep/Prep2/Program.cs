using System;

class Program
{
    static void Main(string[] args)
    {
        // Constants & Variables
        string letterGrade = "";
        string signGrade = "";
        
        // User Input
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        
        // Early Calculations
        double floatGrade = double.Parse(userInput);  // Parse the input as a double
        
        // Round the grade to avoid truncation issues
        int numericGrade = (int)Math.Floor(floatGrade);  // Round the float to the nearest int
        Console.Write($"{numericGrade} ");
        
        double remanent = floatGrade - numericGrade + 0.00001; // Calculate the decimal part

        // Sign calculation
        if (remanent >= 0.7)
        {
            signGrade = "+";
        }
        else if (remanent <= 0.3)
        {
            signGrade = "-";
        }
        else
        {
            signGrade = "";
        }

        // Letter grade logic
        if (floatGrade >= 93.00001)
        {
            letterGrade = "A";  // A for above of 93
        }
        else if (floatGrade >= 90)
        {
            letterGrade = "-A"; // A- for 90-93
        }
        else if (floatGrade >= 80)
        {
            letterGrade = signGrade + "B";
        }
        else if (floatGrade >= 70)
        {
            letterGrade = signGrade + "C";
        }
        else if (floatGrade >= 60)
        {
            letterGrade = signGrade + "D";
        }
        else
        {
            letterGrade = "F"; // No F+ or F- grades
        }

        // Output
        Console.WriteLine($"The grade is: {letterGrade}");

        if (floatGrade >= 70)
        {
            Console.WriteLine("You rock!");
        }
        else
        {
            Console.WriteLine("See you later!");
        }
    }
}
