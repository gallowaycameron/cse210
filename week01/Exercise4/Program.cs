using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        int number = -1;

        List<int> listNumbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter Number: ");
            userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                listNumbers.Add(number);
            }
        }

        if (number == 0)
        {
            int sum = listNumbers.Sum();
            double average = listNumbers.Average();
            int highestNumber = listNumbers[0];

            foreach (int numbers in listNumbers)
            {
                if (numbers > highestNumber)
                {
                    highestNumber = numbers;
                }
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {highestNumber}");
        }
    }
}

//Teachers Example:

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<int> numbers = new List<int>();

//         // Please note we could use a do-while loop here instead
//         int userNumber = -1;
//         while (userNumber != 0)
//         {
//             Console.Write("Enter a number (0 to quit): ");

//             string userResponse = Console.ReadLine();
//             userNumber = int.Parse(userResponse);

//             // Only add the number to the list if it is not 0
//             if (userNumber != 0)
//             {
//                 numbers.Add(userNumber);
//             }
//         }

//         // Part 1: Compute the sum
//         int sum = 0;
//         foreach (int number in numbers)
//         {
//             sum += number;
//         }

//         Console.WriteLine($"The sum is: {sum}");

//         // Part 2: Compute the average
//         // Notice that we first cast the sum variable to be a float. Otherwise, because
//         // both the sum and the count are integers, the computer will do integer division
//         // and I will not get a decimal value (even though it puts the result into a float variable).

//         // By making one of the variables a float first, the computer knows that it has to
//         // do the floating point division, and we get the decimal value that we expect.
//         float average = ((float)sum) / numbers.Count;
//         Console.WriteLine($"The average is: {average}");

//         // Part 3: Find the max
//         // There are several ways to do this, such as sorting the list

//         int max = numbers[0];

//         foreach (int number in numbers)
//         {
//             if (number > max)
//             {
//                 // if this number is greater than the max, we have found the new max!
//                 max = number;
//             }
//         }

//         Console.WriteLine($"The max is: {max}");
//     }
// }