using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class TBoard : UserControl
    {
        public static int N = 8;
        public TCell[,] Cells = new TCell[N, N];
        public TPlayer WhitePlayer = new TPlayer();
        public TPlayer BlackPlayer = new TPlayer();
        public TPlayer ActivePlayer;
        public List<TMove> Moves = new List<TMove>();
        private TPiece _ActivePiece;
        public TPiece ActivePiece
        {
            get
            {
                return _ActivePiece;
            }
            set
            {
                foreach (var cell in Cells) cell.isHighlighted = false;
                
                _ActivePiece = value;
                if (_ActivePiece != null)
                {
                    var moves = _ActivePiece.GetMoves();
                    foreach (var move in moves)
                    {
                        move.StopCell.isHighlighted = true;
                    }
                }
                Invalidate();
            }
        }

        public TBoard()
        {
            InitializeComponent();
            DoubleBuffered = true;
            for (int y = 0; y < N; y++)
                for (int x = 0; x < N; x++)
                {
                    var cell = new TCell();
                    cell.Board = this;
                    cell.X = x;
                    cell.Y = y;
                    Cells[y, x] = cell;
                }
            Reset();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.ScaleTransform(CellWidth, CellHeight);
            var brush = new SolidBrush(ForeColor);

            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    var cell = Cells[y, x];
                    brush.Color = ForeColor;
                    if ((x + y) % 2 == 0)
                        brush.Color = BackColor;
                    if (cell == ActivePiece?.Cell)
                        brush.Color = Color.Red;
                    if (cell.isHighlighted)
                        brush.Color = Color.Magenta;
                    var rc = new RectangleF(x, y, 1, 1);
                    e.Graphics.FillRectangle(brush, rc);
                }
                var player = BlackPlayer;
                for (int i = 0; i < 2; i++)
                {
                    foreach (var piece in player.Pieces)
                    {
                        var rc = new RectangleF(piece.Cell.X, piece.Cell.Y, 1, 1);
                        var image = piecesImages.Images[piece.ImageId + i];
                        e.Graphics.DrawImage(image, rc);
                    }
                    player = WhitePlayer;
                }
            }
        }

        public float CellWidth
        {
            get { return (float)Width / N; }
        }
        public float CellHeight
        {
            get { return (float)Height / N; }
        }
        private void TBoard_Load(object sender, EventArgs e)
        {

        }
        public void Reset()
        {
            Moves.Clear();
            ActivePlayer = BlackPlayer;
            var player = WhitePlayer;
            for(int i=0; i<2; i++)
            {
                player.Board = this;
                new TRook(player);
                new TKnight(player);
                new TBishop(player);
                new TQueen(player);
                new TKing(player);
                new TBishop(player);
                new TKnight(player);
                new TRook(player);
                for (int j = 0; j < N; j++)
                    new TPawn(player);
                for(int j = 0; j<player.Pieces.Count; j++)
                {
                    var x = j % N;
                    var y = j / N;
                    if (player == BlackPlayer)
                        y = N - 1 - y;
                    player.Pieces[j].Cell = Cells[y, x];
                }
                player = BlackPlayer;
            }
        }
        public TCell CellAt(float x, float y)
        {
            y /= CellHeight;
            x /= CellWidth;
            if (x < 0) x = 0;
            if (x > N-1) x = N-1;
            if (y < 0) y = 0;
            if (y > N-1) y = N-1;
            return Cells[(int)y, (int)x];
        }

        TCell StartCell;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            StartCell = CellAt(e.X, e.Y);
            ActivePiece = StartCell.Piece;
            if (ActivePiece?.Player != ActivePlayer) ActivePiece = null;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if(e.Button == MouseButtons.Left && ActivePiece != null)
            {
                ActivePiece.Cell = CellAt(e.X, e.Y);
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if(ActivePiece != null)
            {
                var stopCell = CellAt(e.X, e.Y);
                ActivePiece.Cell = StartCell;
                if (stopCell.isHighlighted)
                {
                    var moves = ActivePiece.GetMoves();
                    var move = moves.Find(x => x.StopCell == stopCell);
                    move.Make();
                    ActivePiece = null;
                }
                Invalidate();
            }
        }
    }


}
