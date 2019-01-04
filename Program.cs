using System;
using System.Collections.Generic;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
      Console.Clear();
      Console.WriteLine("You must choose, Rock, Paper, or Scissors?!");
      string userChoice = Console.ReadLine();

      Random n = new Random();
      int computerChoice = n.Next(3);

      if (computerChoice == 0) //tie
      {
        if (userChoice == "Rock")
        {
           System.Console.WriteLine("Player chose rock!"); 
           System.Console.WriteLine("Computer chose rock, its a tie!");
        }
        else if (userChoice == "Paper")
        {
          System.Console.WriteLine("Player chose paper!");
          System.Console.WriteLine("Computer chose paper, its a tie!");
        }
        else if (userChoice == "Scissors")
        {
          System.Console.WriteLine("Player chose scissors!");  
          System.Console.WriteLine("Computer chose scissors, its a tie!");
        }
        else 
        {
          System.Console.WriteLine("You must choose, Rock, Paper, or Scissors?!");  
        }
      }

      else if (computerChoice == 1) // lose
      {
        if (userChoice == "Rock")
        {
          System.Console.WriteLine("Player chose rock!");
          System.Console.WriteLine("Computer chose paper, you lose!");
        }
        else if (userChoice == "Paper")
        {
          System.Console.WriteLine("Player chose paper!");
          System.Console.WriteLine("Computer chose scissors, you lose!");
        }
        else if (userChoice == "Scissors")
        {
          System.Console.WriteLine("Player chose scissors!");
          System.Console.WriteLine("Computer chose rock, you lose!");
        }
        else
        {
          System.Console.WriteLine("You must choose, Rock, Paper, or Scissors?!");
        }
      }

      else if (computerChoice == 2) //win
      {
        if (userChoice == "Rock")
        {
          System.Console.WriteLine("Player chose rock!");
          System.Console.WriteLine("Computer chose scissors, you win!");
        }
        else if (userChoice == "Paper")
        {
          System.Console.WriteLine("Player chose paper!");
          System.Console.WriteLine("Computer chose rock, you win!");
        }
        else if (userChoice == "Scissors")
        {
          System.Console.WriteLine("Player chose scissors!");
          System.Console.WriteLine("Computer chose rock, you win!");
        }
        else
        {
          System.Console.WriteLine("You must choose, Rock, Paper, or Scissors?!");
        }
      }
      Console.ReadLine();
    }
    }
    }

