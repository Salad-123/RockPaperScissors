using System;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.IO;

class Program
{
    public static string playerOne = "";
    public static string playerTwo = "";
    private static string playerOneMove = "";
    private static string playerTwoMove = "";

    public static void Main(string[] args)
    {
        GameTitle();
        //do while to repeat game depending on user choice
        do
        {
            //The Console.Writeline(" ");'s add blank space between the different functions to avoid clutter
            Console.WriteLine(" ");
            playerOne = InputName(1);
            Console.WriteLine(" ");
            playerTwo = InputName(2);
            Console.WriteLine(" ");
            Console.WriteLine($"Welcome {playerOne} and {playerTwo}!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            playerOneMove = InputMove(playerOne);
            Console.WriteLine(" ");
            playerTwoMove = InputMove(playerTwo);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            GameResult();
            Console.WriteLine(" ");
        } while (PlayAgain());
    }

    // Displays the game title
    public static void GameTitle()
    {
        Console.WriteLine("***  Welcome to Rock Paper Scissors  ***");
        Console.WriteLine("Let's Begin");
    }

    // Prompts the user to enter their name and returns the name as a string
    public static string InputName(int number)
    {
        Console.WriteLine("Player " + number + " enter your name and press enter: ");
        return Console.ReadLine();
    }

    // Prompts the user to enter their move asn "Rock", "Paper" or "Scissors" and returns the move as string
    public static string InputMove(string name)
    {

        Console.WriteLine($"{name}, it's your move.");
        Console.WriteLine("Enter 'Rock' for Rock, 'Paper' for Paper or 'Scissors' for Scissors and press enter");
        Console.WriteLine("Make sure to capatilize your choice!");
        return Console.ReadLine();
    }

    // Compares the moves of player one and player two and displays the result of the game
    public static void GameResult()
    {
        if ((playerOneMove == "Rock" && playerTwoMove == "Scissors") ||
            (playerOneMove == "Paper" && playerTwoMove == "Rock") ||
            (playerOneMove == "Scissors" && playerTwoMove == "Paper"))
        {

            Console.WriteLine($"{playerOne} wins! {playerOne}'s {playerOneMove} beats {playerTwo}'s {playerTwoMove}!");
        }
        else if ((playerTwoMove == "Rock" && playerOneMove == "Scissors") ||
                 (playerTwoMove == "Paper" && playerOneMove == "Rock") ||
                 (playerTwoMove == "Scissors" && playerOneMove == "Paper"))
        {
            Console.WriteLine($"{playerTwo} wins! {playerTwo}'s {playerTwoMove} beats {playerOne}'s {playerOneMove}!");
        }
        else if (playerOneMove == playerTwoMove)
        {
            Console.WriteLine("It's a tie!");
        }
        else
        {
            Console.WriteLine("Invalid move chosen, please start the game over again");
        }
    }

    // Prompts the user to press "y" to play again or "n" to exit program
    public static bool PlayAgain()
    {
        Console.WriteLine("Thanks for playing Rock, Paper, Scissors!") ;
        Console.WriteLine("Do you want to play again? (y/n)?");
        string answer = Console.ReadLine().ToLower();

        if (answer == "y")
        {
            Console.Clear();
            GameTitle();
            return true;
        }
        else if (answer == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            return PlayAgain();
        }
    }
}
