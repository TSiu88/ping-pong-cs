using System;
using Game.Models;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      PingPong game = new PingPong();
      game.AskUserInput();
      int userInput = int.Parse(Console.ReadLine());

      foreach (string item in game.PrintUserInput(userInput))
      {
        Console.WriteLine(item);
      }
      
    }
  }
}