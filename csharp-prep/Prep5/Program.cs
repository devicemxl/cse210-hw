using System;

    void DisplayWelcome(){
        //clean screen
        Console.Clear();
        Console.WriteLine("Welcome to the Program!");
    }
    string PromptUserName(){
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    float PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        return float.Parse(favoriteNumber);
    }
    float SquaredNumber(float aNumber){
        return aNumber * aNumber;
    }
    void DisplayResult(){
        string userName = PromptUserName();
        float aNumber = PromptUserNumber();
        float sqNumber = SquaredNumber(aNumber);
        Console.Write($"{userName}, the square of your number is {sqNumber} \n");
    }

    DisplayWelcome();
    DisplayResult();