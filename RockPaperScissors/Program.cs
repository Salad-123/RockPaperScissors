using System;

using System.IO;

class Program
{
    public static string playerOne = "";
    public static string playerTwo = "";
    private static string playerOneMove = "";
    private static string playerTwoMove = "";


    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        // Do while loop to repeat game depending on user choice
        do
        {
            // The Console.Writeline(" ");'s add blank space between the different functions to avoid clutter
            // Running functions
            GameTitle();
            Console.WriteLine(" ");
            playerOne = InputName(1);
            Console.WriteLine(" ");
            playerTwo = InputName(2);
            Console.WriteLine(" ");
            // Greets the users once they enter their names
            Console.WriteLine($"Welcome {playerOne} and {playerTwo}!");
            Console.WriteLine("Press any key to continue...");
            // Allows users to continue by pressing any key
            Console.ReadKey(true);
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

    // Asks the user to enter their name and returns the input
    public static string InputName(int number)
    {
        Console.WriteLine("Player " + number + " enter your name and press enter: ");
        return Console.ReadLine();
    }

    // Asks the user to enter their move as "Rock", "Paper" or "Scissors" and returns the input
    public static string InputMove(string name)
    {

        Console.WriteLine($"{name}, it's your move.");
        Console.WriteLine("Enter 'Rock' for Rock, 'Paper' for Paper or 'Scissors' for Scissors and press enter");
        Console.WriteLine("Make sure to capatilize your choice!");
        return Console.ReadLine();
    }

    // Compares the moves of player one and player two and prints the result of the game
    public static void GameResult()
    {
        if ((playerOneMove == "Rock" && playerTwoMove == "Scissors") 
            || (playerOneMove == "Paper" && playerTwoMove == "Rock") 
            || (playerOneMove == "Scissors" && playerTwoMove == "Paper"))
        {

            Console.WriteLine($"{playerOne} wins! {playerOne}'s {playerOneMove} beats {playerTwo}'s {playerTwoMove}!");
        }
        else if ((playerTwoMove == "Rock" && playerOneMove == "Scissors") 
                || (playerTwoMove == "Paper" && playerOneMove == "Rock") 
                || (playerTwoMove == "Scissors" && playerOneMove == "Paper"))
        {
            Console.WriteLine($"{playerTwo} wins! {playerTwo}'s {playerTwoMove} beats {playerOne}'s {playerOneMove}!");
        }
        else if (playerOneMove == playerTwoMove)
        {
            Console.WriteLine("It's a tie!");
        }
        else
        {
            Console.WriteLine("Invalid move chosen, please start the game over again.");
        }
    }

    // Asks the user to press "y" to play again or "n" to exit program
    public static bool PlayAgain()
    {
        Console.WriteLine("Thanks for playing Rock, Paper, Scissors!");
        Console.WriteLine("Do you want to play again? (y/n)?");
        string answer = Console.ReadLine();

        if (answer == "y")
        {
            Console.Clear();
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
