using System.Runtime.CompilerServices;

namespace NHT;

public class Piece
{
    public char Symbol { get; private set; }
    public string Color;
    private int Pieces { get; set; }
    private int PiecesInHouse { get; set; }
    private int PiecesInSafeSpot { get; set; }

    public Piece(string color)
    {
        Pieces = 4;
        PiecesInHouse = 3;
        PiecesInSafeSpot = 0;
        Color = color;
        Symbol = '\u265f';
    }

    public bool IsColor(Piece piece)
    {
        if (piece.Color == this.Color)
        {
            return true;
        }

        return false;
    }
}