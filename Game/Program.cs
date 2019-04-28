using System;
using System.Collections.Generic;
namespace Game.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine ("Player one");
      string PlayerOne = Console.ReadLine();
      Console.WriteLine ("Player two");
      string PlayerTwo = Console.ReadLine();
      MyGame newGame = new MyGame(PlayerOne,PlayerTwo);
      Console.WriteLine ("Winner" + newGame.FindWinner());
    }
  }
}
