using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Game.Models;

namespace Game.Tests
{
  [TestClass]
  public class PingPongTests
  {
    [TestMethod]
    public void PrintUserInput_ShowsOutput_StringList()
    {
      PingPong testGame = new PingPong();
      List<string> testList = new List<string> { "1", "2", "\"ping\"", "4", "\"pong\"" };
      CollectionAssert.AreEqual(testList, testGame.PrintUserInput(5));
    }
  }
}