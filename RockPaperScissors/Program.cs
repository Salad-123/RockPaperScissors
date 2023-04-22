using System;
using System.IO;

class Program
{
    public static string playerOne  = "";
    public static string playerTwo = "";
    public static void Main (string[] args)
    {
        GameTitle();
        playerOne = InputName(1);
        playerTwo = InputName(2);
        Console.WriteLine($"Welcome {playerOne} and {playerTwo}!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

    }
    public static void GameTitle()
    {
        //Displays game title
        Console.WriteLine("***  Welcome to Rock Paper Scissors  ***");
        Console.WriteLine("Lets Begin");
        Console.WriteLine();
    }
    public static string InputName(int number)
    {
        Console.WriteLine("Player " + number + " enter your name and press enter: ");
        return _ = Console.ReadLine();
    }

}