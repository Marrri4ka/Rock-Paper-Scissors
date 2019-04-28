using System;
using System.Collections.Generic;

namespace Game.Models
{
  public class MyGame
  {
    private string _player1;
    private string _player2;

    public MyGame (string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;
    }

    public string FindWinner()
    {
      return "Winner player1";
    }
  }
}
