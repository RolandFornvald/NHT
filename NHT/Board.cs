using System.Net.NetworkInformation;

namespace NHT;

public class Board
{
    private char[,] _board = new char[11, 11];
    private Piece[,] _charBoard = new Piece[11, 11];
    private Piece green = new Piece("green");
    private Piece blue = new Piece("blue");
    private Piece red = new Piece("red");
    private Piece yellow = new Piece("yellow");

    public void CreateBoard()
    {
        for (int i = 0; i < _board.GetLength(0); i++)
        {
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                _board[i, j] = ' ';
            }
        }
        //Yellow Player
        {
            _board[0, 0] = yellow.Symbol;
            _board[1, 1] = yellow.Symbol;
            _board[0, 1] = yellow.Symbol;
            _board[1, 0] = yellow.Symbol;
            
            _charBoard[0, 0] = yellow;
            _charBoard[1, 1] = yellow;
            _charBoard[0, 1] = yellow;
            _charBoard[1, 0] = yellow;

        }
        //Green Player
        {
        
            _board[0, 10] = green.Symbol;
            _board[1, 9] = green.Symbol;
            _board[0, 9] = green.Symbol;
            _board[1, 10] = green.Symbol;
            
            _charBoard[0, 10] = green;
            _charBoard[1, 9] = green;
            _charBoard[0, 9] = green;
            _charBoard[1, 10] = green;
        
        }
        //Red Player
        {
            _board[10, 10] = red.Symbol;
            _board[9, 9]   = red.Symbol;
            _board[9, 10]  = red.Symbol;
            _board[10, 9]  = red.Symbol;
            
            _charBoard[10, 10] = red;
            _charBoard[9, 9]   = red;
            _charBoard[9, 10]  = red;
            _charBoard[10, 9]  = red;
        }
        //Blue Player
        {
            _board[10, 0] = blue.Symbol;
            _board[10, 1] = blue.Symbol;
            _board[9, 1]  = blue.Symbol;
            _board[9, 0]  = blue.Symbol;
            
            _charBoard[10, 0] = blue;
            _charBoard[10, 1] = blue;
            _charBoard[9, 1]  = blue;
            _charBoard[9, 0]  = blue;
        }
        //first quarter
        {
            for (int i = 0; i < 4; i++)
            {
                _board[4, i] = '\u25cb';
            }

            for (int i = 4; i >= 0; i--)
            {
                _board[i, 4] = '\u25cb';
            }

            _board[0, 5] = '\u25cb';
        }
        //second quarter
        {
            for (int i = 0; i < 4; i++)
            {
                _board[i, 6] = '\u25cb';
            }

            for (int i = 6; i < 11; i++)
            {
                _board[4, i] = '\u25cb';
            }

            _board[5, 10] = '\u25cb';
        }
        //third quarter
        {
            for (int i = 10; i >= 6; i--)
            {
                _board[6, i] = '\u25cb';
            }

            for (int i = 6; i < 11; i++)
            {
                _board[i, 6] = '\u25cb';
            }
            
            _board[10, 5] = '\u25cb';
        }
        //fourth quarter
        {
            for (int i = 10; i >= 6; i--)
            {
                _board[i, 4] = '\u25cb';
            }

            for (int i = 0; i < 4; i++)
            {
                _board[6, i] = '\u25cb';
            }

            _board[5, 0] = '\u25cb';
        }
        for (int i = 1; i < 5; i++)
        {
            _board[5, i] = Convert.ToChar(Convert.ToString(i));
        }

        for (int i = 1; i < 5; i++)
        {
            _board[i,5] = Convert.ToChar(Convert.ToString(i));
        }

        int tmp = 1;
        for (int i = 9; i >= 6; i--)
        {
            _board[i,5] = Convert.ToChar(Convert.ToString(tmp));
            tmp++;
        }
        tmp = 1;
        for (int i = 9; i >= 6; i--)
        {
            _board[5, i] = Convert.ToChar(Convert.ToString(tmp));
            tmp++;
        }
        _board[4, 4] = '\u2b50';
        _board[6, 4] = '\u2b50';
        _board[4, 6] = '\u2b50';
        _board[6, 6] = '\u2b50';
    }

    public void PrintBoard()
    {
        Console.Clear();
        for (int i = 0; i < _board.GetLength(0); i++)
        {
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                if (_board[i, j] == '\u265f')
                {
                    if (_charBoard[i,j].Color == yellow.Color)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" " + _board[i,j] + " ");
                        Console.ResetColor();
                    }
                    if (_charBoard[i,j].Color == green.Color)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" " + _board[i,j] + " ");
                        Console.ResetColor();
                    }
                    if (_charBoard[i,j].Color == red.Color)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" " + _board[i,j] + " ");
                        Console.ResetColor();
                    }
                    if (_charBoard[i,j].Color == blue.Color)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" " + _board[i,j] + " ");
                        Console.ResetColor();
                    }
                    
                }
                else
                {
                    Console.Write(" " + _board[i,j] + " ");
                }
                
            }
            Console.WriteLine();
        }
    }

    public bool CheckForWinner()
    {
        
        return false;
    }
}