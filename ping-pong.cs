using System;

class PingPong
{
  static void Main()
  {
    AskUserInput();
    int userInput = int.Parse(Console.ReadLine());
    Console.WriteLine(userInput);
  }

  static void AskUserInput()
  {
    Console.WriteLine("Enter a number:");
  }

}