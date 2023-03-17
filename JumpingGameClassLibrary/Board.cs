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
        public int[][] GenerateBoard()
        {
            var board = new int[8][]; ;
            for (int i = 0; i < 8; i++)
            {
                var row = new int[100];
                for (int j = 0; j < 100; j++)
                {
                    if (i == 7) row[j] = 2;
                    else row[j] = 0;
                }
                board[i] = row;
            }
            return board;
        }
        public string GetBoardAsString(int[][] board)
        {
            var output = @"";
            for(var i = 0; i < 8; i++)
            {
                var row = board[i];
                var rowString = "";
                foreach (var space in row)
                {
                    if (space == 0)
                        rowString += " ";
                    else if (space == 2)
                        rowString += "T";
                }
                if (i < 7)
                    rowString += "\n";
                output += rowString;
            }
            return output;
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
