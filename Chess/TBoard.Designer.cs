namespace Chess
{
    partial class TBoard
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBoard));
            this.piecesImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // piecesImages
            // 
            this.piecesImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("piecesImages.ImageStream")));
            this.piecesImages.TransparentColor = System.Drawing.Color.Red;
            this.piecesImages.Images.SetKeyName(0, "Bishop.bmp");
            this.piecesImages.Images.SetKeyName(1, "BishopBlack.bmp");
            this.piecesImages.Images.SetKeyName(2, "King.bmp");
            this.piecesImages.Images.SetKeyName(3, "KingBlack.bmp");
            this.piecesImages.Images.SetKeyName(4, "Knight.bmp");
            this.piecesImages.Images.SetKeyName(5, "KnightBlack.bmp");
            this.piecesImages.Images.SetKeyName(6, "Pawn.bmp");
            this.piecesImages.Images.SetKeyName(7, "PawnBlack.bmp");
            this.piecesImages.Images.SetKeyName(8, "Queen.bmp");
            this.piecesImages.Images.SetKeyName(9, "QueenBlack.bmp");
            this.piecesImages.Images.SetKeyName(10, "Rook.bmp");
            this.piecesImages.Images.SetKeyName(11, "RookBlack.bmp");
            // 
            // TBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TBoard";
            this.Size = new System.Drawing.Size(225, 231);
            this.Load += new System.EventHandler(this.TBoard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList piecesImages;
    }
}
