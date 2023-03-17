using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingGameClassLibrary
{
    public class Board
    {
        public bool GameIsRunning { get; set; }
        public Board()
        {
            GameIsRunning = false;
        }
        public string GenerateBoard()
        {
            // Haven't figured out dimensions. y = 5(could be higher), x = ?
            return "hi";
        }

        public void UpdateBoard()
        {
            throw new NotImplementedException();
        }

        public void EndGame()
        {
            GameIsRunning = false;
        }

        public void RunGame()
        {
            GameIsRunning = true;

        }
    }
}
