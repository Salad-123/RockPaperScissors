using System;
using System.IO;

class Program
{
    string playerOne = "";
    public static void Main (string[] args)
    {
        //Displays game title
        Console.WriteLine("***Welcome to Rock Paper Scissors***");
        Console.WriteLine("Lets Begin");
        Console.WriteLine(" ");
        
        //Asks users for name and saves to variables playerOne and playerTwo
        Console.WriteLine("Player 1, enter your name and press enter: ");
        string playerOne = Console.ReadLine();
        Console.WriteLine("Player 2, enter your name and press enter: ");
        string playerTwo = Console.ReadLine();
        Console.WriteLine("Welcome "+playerOne+" and "+playerTwo);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey()
    }
}