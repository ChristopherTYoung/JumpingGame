// See https://aka.ms/new-console-template for more information
using JumpingGameClassLibrary;

var board = new Board();
var boardArray = board.GenerateBoard();
var boardString = board.GetBoardAsString(boardArray);

Console.WriteLine(boardString);
string expectedString = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT";
Console.WriteLine(expectedString);