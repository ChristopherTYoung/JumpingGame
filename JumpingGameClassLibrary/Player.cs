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
            // call time tik
            // y position change
                // if(position 0)
           if (PlayerHasJumped) 
           {
                // set to position 1 y = 3
                Y_Position = 3;
                // call tik
           }

            // elseif(position 1 && position 2 has not occured)
           //else if()
           //{
                // set to position 2 y = 2
                // call tik and wait
                // call tik
                //Y_Position = 2;

            //}
            

            // elseif(position 2 )
            //else if ()
            //{
                // set to position 1 y = 3
                // call tik
                //Y_Position = 3;
            //}
            

            //  elseif(position 1 && position 2 has occured)
            //else if ()
            //{
                // set to position 0 y = 4
                //call tik
                //Y_Position = 4;
            //}
            

            // else (position is 0)
            //else
            //{
                // set PlayerHasJumped = false
                //Y_Position = 4;
                //PlayerHasJumped = false;
            //}
            
        }
        public void Duck()
        { 
            throw new NotImplementedException();
        }
    }
}
