namespace Chess
{
    public class TCell
    {
        public int X;
        public int Y;
        public bool isHighlighted;
        //public TPiece Piece;
        public TBoard Board;

        public TPiece Piece
        {
            get
            {
                var piece = Board.WhitePlayer.PieceAtCell(this);
                if (piece == null)
                {
                    piece = Board.BlackPlayer.PieceAtCell(this);
                }
                return piece;
            }
        }
        public TCell GetNeighbor(int offX, int offY)
        {
            var x = X + offX;
            var y = Y + offY;
            if (x >= 0 && x < TBoard.N && y >= 0 && y < TBoard.N) { return Board.Cells[y, x]; }
            return null;
        }
    }
}