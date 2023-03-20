using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingGameClassLibrary
{
    public class Player : IGame
    {
        public int Y_Position { get; set; }
        public string[] Icon { get; set; }
        public Player() 
        {
            Y_Position = 7;
            Icon = new string[] { "O", "|", "L" };
        }
        public int[] Generate(string[] Icon)
        {
            throw new NotImplementedException();
        }
        public void Jump()
        {
            throw new NotImplementedException();
        }
        public void Duck()
        { 
            throw new NotImplementedException();
        }
    }
}
