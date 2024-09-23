using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<int> reverseList = new List<int>();
        //
        // Continuos User Input
        //
        int userNumber;
        string userResponse;
        do
        {
            //clean screen
            Console.Clear();
            // do it
            Console.Write("Enter a number (0 to quit, or press Enter to quit): ");
            userResponse = Console.ReadLine();
            // Check if the input is empty or null, then break the loop
            if (string.IsNullOrEmpty(userResponse))
            {
                break;
            }
            // Try parsing the input, if it's a valid number, continue; if not, give feedback and loop again
            bool isNumber = int.TryParse(userResponse, out userNumber);
            if (!isNumber)
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
                continue; // Ask for the input again without adding to the list
            }
            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);
        //
        //
        // If user enter some numbers
        // ==========================
        //
        //
        if (numbers.Count > 0)
        {
            // Overall sum
            int suma = 0;
            foreach (int numero in numbers)
            {
                suma += numero;
            }
            // Average
            double average = ((double)suma) / numbers.Count;
            // Max, avoiding more libraries
            numbers.Sort(); // Sort the list
            int maxNumber = numbers[numbers.Count - 1]; // The last element is the maximum
            //
            //
            // Printing
            // ==============
            //
            //
            Console.WriteLine($"The Sum:     {suma}");
            Console.WriteLine($"The average: {average}");
            Console.WriteLine($"The max:     {maxNumber}");
            //
            //
            Console.WriteLine($"The ordered list is");
            // Sort the list
            numbers.Sort();
            // Print in ascending order
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        //
        //
        // If user doent enter any number
        // ===============================
        //
        //
        else
        {
            Console.WriteLine("No numbers on list");
        }
    }

}