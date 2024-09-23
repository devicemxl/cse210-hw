using System;

    static void DisplayWelcome(){
        //clean screen
        Console.Clear();
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static float PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        return float.Parse(favoriteNumber);
    }
    static float SquaredNumber(float aNumber){
        return aNumber * aNumber;
    }
    static void DisplayResult(){
        string userName = PromptUserName();
        float aNumber = PromptUserNumber();
        float sqNumber = SquaredNumber(aNumber);
        Console.Write($"{userName}, the square of your number is {sqNumber} \n");
    }

    DisplayWelcome();
    DisplayResult();