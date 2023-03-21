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
        public bool PlayerHasJumped { get; set; }
        public bool PlayerHasDucked { get; set; }
        public Player() 
        {
            Y_Position = 4;
        }
        public string[] Generate()
        {
            if (PlayerHasDucked) return new string[] { "L", "O" };
            else return new string[] { "L", "Y", "O" };
        }
        public void Jump()
        {
            PlayerHasJumped = true;
            throw new NotImplementedException();
        }
        public void Duck()
        { 
            throw new NotImplementedException();
        }
    }
}
