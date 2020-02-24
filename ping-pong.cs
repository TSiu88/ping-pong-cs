using System;

class PingPong
{
  static void Main()
  {
    AskUserInput();
    int userInput = int.Parse(Console.ReadLine());
    printUserInput(userInput);
  }

  static void AskUserInput()
  {
    Console.WriteLine("Enter a number:");
  }

  static void printUserInput(int input)
  {
    for (int i = 1; i <= input; i++)
    {
      Console.WriteLine(i);
    }
  }

}