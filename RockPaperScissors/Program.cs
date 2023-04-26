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
    public static string[] moves = { "Rock", "Paper", "Scissors" };
    public static int gamesPlayed = 1;
    private static int playerOneScore = 0;
    private static int playerTwoScore = 0;

    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        GameTitle();
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
        //do while to repeat game depending on user choice
        do
        {
            Console.WriteLine($"Round {gamesPlayed}!");
            Console.WriteLine(" ");
            playerOneMove = InputMove(playerOne);
            Console.WriteLine(" ");
            playerTwoMove = InputMove(playerTwo);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            GameResult();
            Console.WriteLine(" ");
            gamesPlayed += PlayAgain();
        } while (gamesPlayed <= 5);
        DisplayScores();
    }

    // Displays the game title
    public static void GameTitle()
    {
        Console.WriteLine("***  Welcome to Rock Paper Scissors  ***");
        Console.WriteLine("Best out of 5");
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
        string answer = "";

        Console.WriteLine($"{name}, it's your move.");

        for (int i = 0; i < moves.Length; i++)
        {
            Console.WriteLine($"{i+1}. {moves[i]}");
        }
        Console.WriteLine($"Enter '1' for {moves[0]}, '2' for {moves[1]} or '3' for {moves[2]}");
        string arrayinput = Console.ReadLine();
        if (arrayinput == "1") {
            answer = "Rock";
        }
        else if (arrayinput == "2"){
            answer = "Paper";
        }
        else if (arrayinput == "3") {
            answer = "Scissors";
        }

        return answer;
    }

    // Compares the moves of player one and player two and displays the result of the game
    public static void GameResult()
    {
        if ((playerOneMove == "Rock" && playerTwoMove == "Scissors") ||
            (playerOneMove == "Paper" && playerTwoMove == "Rock") ||
            (playerOneMove == "Scissors" && playerTwoMove == "Paper"))
        {

            Console.WriteLine($"{playerOne} wins! {playerOne}'s {playerOneMove} beats {playerTwo}'s {playerTwoMove}!");
            playerOneScore += 1;
        }
        else if ((playerTwoMove == "Rock" && playerOneMove == "Scissors") ||
                 (playerTwoMove == "Paper" && playerOneMove == "Rock") ||
                 (playerTwoMove == "Scissors" && playerOneMove == "Paper"))
        {
            Console.WriteLine($"{playerTwo} wins! {playerTwo}'s {playerTwoMove} beats {playerOne}'s {playerOneMove}!");
            playerTwoScore += 1;
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
    public static int PlayAgain()
    {
        Console.WriteLine("Thanks for playing Rock, Paper, Scissors!") ;
        Console.WriteLine("Do you want to play again? (y/n)?");
        string answer = Console.ReadLine().ToLower();

        if (answer == "y")
        {
            Console.Clear();
            return 1;
        }
        else if (answer == "n")
        {
            return 5;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            return PlayAgain();
        }
    }
    public static void DisplayScores()
    {
        if (playerOneScore == playerTwoScore)
        {
            Console.WriteLine($"Over 5 games, {playerOne} and {playerTwo} both scored {playerOneScore}");
        }
        else if (playerOneScore  > playerTwoScore)
        {
            Console.WriteLine($"Over 5 games, {playerOne} wins with a score of {playerOneScore}");
        }
        else if (playerOneScore < playerTwoScore)
        {
            Console.WriteLine($"Over 5 games, {playerTwo} wins with a score of {playerTwoScore}");
        }
    
    }


}
