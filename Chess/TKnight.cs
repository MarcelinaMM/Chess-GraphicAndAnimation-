using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class TKnight : TPiece
    {
        public TKnight(TPlayer player) : base(player)
        {
            ImageId = 4;
            Value = 3;
        }
        public override List<TCell> GetFreeCells()
        {
            var cells = new List<TCell>();
            cells.Add(Cell.GetNeighbor(2, -1));
            cells.Add(Cell.GetNeighbor(2, 1));
            cells.Add(Cell.GetNeighbor(-2, -1));
            cells.Add(Cell.GetNeighbor(-2, 1));
            cells.Add(Cell.GetNeighbor(-1, 2));
            cells.Add(Cell.GetNeighbor(1, 2));
            cells.Add(Cell.GetNeighbor(-1, -2));
            cells.Add(Cell.GetNeighbor(1, -2));
            return cells;
        }
    }
}
