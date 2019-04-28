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

      string compare = _player1+" "+_player2;
      Dictionary<string,string> dict = new Dictionary <string, string>();
      dict.Add ("rock scissors", "winner1");
      dict.Add ("paper rock", "winner1");
      dict.Add ("paper scissors ", "winner2");

      return dict[compare];
    }
  }
}
