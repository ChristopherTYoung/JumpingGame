using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JumpingGameClassLibrary
{
    public class Board
    {
        public bool GameIsRunning { get; set; }
        public Player _player;
        public Board()
        {
            GameIsRunning = false;
            _player = new Player();
        }
        public int[][] GenerateBoard(string[] player)
        {
            var LengthOfPlayer = player.Length;
            var playerPosition = _player.Y_Position;
            var board = new int[8][]; ;
            for (int i = 0; i < 8; i++)
            {
                var row = new int[100];
                for (int j = 0; j < 100; j++)
                {
                    if (i == 7) row[j] = 2;
                    else if(i == playerPosition && j == 3 && i != 7)
                    {
                        row[j] = 1;
                        LengthOfPlayer--;
                        playerPosition++;
                    }
                    else row[j] = 0;
                }
                board[i] = row;
            }
            return board;
        }
        public string GetBoardAsString(int[][] board, string[] player)
        {
            var LengthOfPlayer = player.Length;
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
                    else if (space == 1 && player.Length != -1)
                    {
                        LengthOfPlayer--;
                        rowString += player[LengthOfPlayer];

                    }
                }
                if (i < 7)
                    rowString += "\n";
                output += rowString;
            }
            return output;
        }
        public void UpdateBoard(int[][] board, Player _player)
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
            var player = _player.Generate();
            var board = GenerateBoard(player);

            //while(GameIsRunning)
            //{

            //}
        }
    }
}
