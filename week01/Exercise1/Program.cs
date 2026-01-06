using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}

// Teachers example

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("What is your first name? ");
//         string first = Console.ReadLine();

//         Console.Write("What is your last name? ");
//         string last = Console.ReadLine();

//         Console.WriteLine($"Your name is {last}, {first} {last}.");
//     }
// }