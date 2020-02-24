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
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("\"ping-pong\"");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("\"ping\"");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("\"pong\"");
      }
      else
      {
      Console.WriteLine(i);
      }
    }
  }

}