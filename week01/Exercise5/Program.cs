using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userInputName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int squared = SquareNumber(favoriteNumber);

        DisplayResults(userInputName, squared);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        string userInputName = "";
        Console.Write("What is your name? ");
        userInputName = Console.ReadLine();
        return userInputName;
    }

    static int PromptUserNumber()
    {
        string userInputNumber = "";
        int favoriteNumber = 0;
        Console.Write("What is your favorite number? ");
        userInputNumber = Console.ReadLine();
        favoriteNumber = int.Parse(userInputNumber);
        return favoriteNumber;
    }

    static int SquareNumber(int favoriteNumber)
    {
        int squareRoot = favoriteNumber * favoriteNumber;
        return squareRoot;
    }

    static void DisplayResults(string userInputName, int squareRoot)
    {
        Console.WriteLine($"{userInputName}, the sqaure root of your number is: {squareRoot}");
    }
}

//Teachers Example:

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         DisplayWelcomeMessage();

//         string userName = PromptUserName();
//         int userNumber = PromptUserNumber();

//         int squaredNumber = SquareNumber(userNumber);

//         DisplayResult(userName, squaredNumber);
//     }

//     static void DisplayWelcomeMessage()
//     {
//         Console.WriteLine("Welcome to the program!");
//     }

//     static string PromptUserName()
//     {
//         Console.Write("Please enter your name: ");
//         string name = Console.ReadLine();

//         return name;
//     }

//     static int PromptUserNumber()
//     {
//         Console.Write("Please enter your favorite number: ");
//         int number = int.Parse(Console.ReadLine());

//         return number;
//     }

//     static int SquareNumber(int number)
//     {
//         int square = number * number;
//         return square;
//     }

//     static void DisplayResult(string name, int square)
//     {
//         Console.WriteLine($"{name}, the square of your number is {square}");
//     }
// }