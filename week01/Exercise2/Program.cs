using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);

        string letter = "";
        string notice = "";

        if (number >= 70)
        {
            notice = "Congratulations, you are passing!";

            if (number >= 90)
            {
                letter = "A";
            }

            else if (number >= 80)
            {
                letter = "B";
            }

            else
            {
                letter = "C";
            }
        }

        else
        {
            notice = "Sorry, you are not passing. Try a little harder";

            if (number >= 60)
            {
                letter = "D";
            }

            else
            {
                letter = "F";
            }

        }

        Console.WriteLine($"Your grade is {letter}. \n{notice}");
    }
}

//Teachers Example:

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("What is your grade percentage? ");
//         string answer = Console.ReadLine();
//         int percent = int.Parse(answer);

//         string letter = "";

//         if (percent >= 90)
//         {
//             letter = "A";
//         }
//         else if (percent >= 80)
//         {
//             letter = "B";
//         }
//         else if (percent >= 70)
//         {
//             letter = "C";
//         }
//         else if (percent >= 60)
//         {
//             letter = "D";
//         }
//         else
//         {
//             letter = "F";
//         }

//         Console.WriteLine($"Your grade is: {letter}");

//         if (percent >= 70)
//         {
//             Console.WriteLine("You passed!");
//         }
//         else
//         {
//             Console.WriteLine("Better luck next time!");
//         }
//     }
// }