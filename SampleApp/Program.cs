using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the name your band?");
        string name = Console.ReadLine();

        Console.WriteLine("How many people are in your band?");
        int numberOfMembers = 0;
        if (!int.TryParse(Console.ReadLine(), out numberOfMembers))
        {
            Console.WriteLine("input was not valid");
            Environment.Exit(0);
        }

        if (numberOfMembers < 1)
        {
            Console.WriteLine("You must have at least 1 member");
            Environment.Exit(0);
        }
        else if (numberOfMembers == 1)
            Console.WriteLine(name + " is a solo");
        else if (numberOfMembers == 2)
            Console.WriteLine(name + " is a duo");
        else
            Console.WriteLine(name + "has " + numberOfMembers + " Members");
    }
}
