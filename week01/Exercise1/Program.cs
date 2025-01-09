using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        
        Console.WriteLine("What is your first name? ");
        string Firstname = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string Lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {Lastname}, {Firstname} {Lastname}.");
        

    }
}