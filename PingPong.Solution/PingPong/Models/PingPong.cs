using System;
using System.Collections.Generic;

namespace Game.Models
{
  public class PingPong
  {

    public void AskUserInput()
    {
      Console.WriteLine("Enter a number:");
    }

    public List<string> PrintUserInput(int input)
    {
      List<string> returnList = new List<string> ();
      for (int i = 1; i <= input; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          returnList.Add("\"ping-pong\"");
        }
        else if (i % 3 == 0)
        {
          returnList.Add("\"ping\"");
        }
        else if (i % 5 == 0)
        {
          returnList.Add("\"pong\"");
        }
        else
        {
          returnList.Add(i.ToString());
        }
      }
      return returnList;
    }
  }
}
