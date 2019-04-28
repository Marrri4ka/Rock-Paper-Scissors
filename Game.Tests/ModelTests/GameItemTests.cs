using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Game.Models;

namespace GameItem.Tests
{
  [TestClass]
  public class ItemTest
  {
    [TestMethod]
    public void FindWinner()
    {
      //Arrange
      MyGame newGame = new MyGame("rock", "paper");
      // Act
      string result = newGame.FindWinner();

      // Assert
      Assert.AreEqual (result, "Winner player1");
    }
  }
}
