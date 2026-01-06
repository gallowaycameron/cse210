using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        string userInput = "";
        int number = -1;

        Console.WriteLine("Welcome to the Number guessing game! Guess a number between 1-100.");

        while (number != magicNumber)
        {
            Console.Write("What is your guess? ");
            userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number > 100 || number < 0)
            {
                Console.WriteLine("Not a Valid Range. Please input a number between 1-100");
            }

            else if (number > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (number < magicNumber)
            {
                Console.WriteLine("Higher");
            }

        }

        if (number == magicNumber)
        {
            Console.WriteLine("You Guessed It!");
        }
    }
}

//Teachers Example:

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // For Parts 1 and 2, where the user specified the number...
//         // Console.Write("What is the magic number? ");
//         // int magicNumber = int.Parse(Console.ReadLine());

//         // For Part 3, where we use a random number
//         Random randomGenerator = new Random();
//         int magicNumber = randomGenerator.Next(1, 101);

//         int guess = -1;

//         // We could also use a do-while loop here...
//         while (guess != magicNumber)
//         {
//             Console.Write("What is your guess? ");
//             guess = int.Parse(Console.ReadLine());

//             if (magicNumber > guess)
//             {
//                 Console.WriteLine("Higher");
//             }
//             else if (magicNumber < guess)
//             {
//                 Console.WriteLine("Lower");
//             }
//             else
//             {
//                 Console.WriteLine("You guessed it!");
//             }

//         }
//     }
// }