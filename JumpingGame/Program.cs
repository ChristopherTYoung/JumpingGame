// See https://aka.ms/new-console-template for more information
using JumpingGameClassLibrary;

var board = new Board();
var player = new Player();
//board.RunGame();
var playerString = player.Generate();
var boardArray = board.GenerateBoard(playerString);
var boardString = board.GetBoardAsString(boardArray, playerString);

Console.WriteLine(boardString);
