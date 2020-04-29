namespace Chess
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoard1 = new Chess.TBoard();
            this.SuspendLayout();
            // 
            // tBoard1
            // 
            this.tBoard1.BackColor = System.Drawing.Color.SeaShell;
            this.tBoard1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tBoard1.Location = new System.Drawing.Point(126, 2);
            this.tBoard1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tBoard1.Name = "tBoard1";
            this.tBoard1.Size = new System.Drawing.Size(1112, 946);
            this.tBoard1.TabIndex = 0;
            this.tBoard1.Load += new System.EventHandler(this.tBoard1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 949);
            this.Controls.Add(this.tBoard1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TBoard tBoard1;
    }
}

