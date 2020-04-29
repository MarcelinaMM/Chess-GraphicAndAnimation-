using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class TKing : TPiece
    {
        public TKing(TPlayer player) : base(player)
        {
            ImageId = 2;
            Value = 1000;
        }

        public override List<TCell> GetFreeCells()
        {
            var cells = new List<TCell>();
            cells.Add(Cell.GetNeighbor(-1, 0));
            cells.Add(Cell.GetNeighbor(-1, -1));
            cells.Add(Cell.GetNeighbor(0, -1));
            cells.Add(Cell.GetNeighbor(1, -1));
            cells.Add(Cell.GetNeighbor(1, 0));
            cells.Add(Cell.GetNeighbor(1, 1));
            cells.Add(Cell.GetNeighbor(0, 1));
            cells.Add(Cell.GetNeighbor(-1, 1));
            if(MoveCount == 0)
            {
                var rook = Cell.GetNeighbor(-4, 0).Piece;
                if(rook != null && rook.MoveCount == 0)
                {
                    for(int i=0; i<4; i++)
                    {
                        var cell = Cell.GetNeighbor(-i, 0);
                    }
                }
            }
            return cells;
        }
    }
}
