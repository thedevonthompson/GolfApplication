namespace GolfApp
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPastGames = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPastGames
            // 
            this.btnPastGames.Location = new System.Drawing.Point(37, 30);
            this.btnPastGames.Name = "btnPastGames";
            this.btnPastGames.Size = new System.Drawing.Size(198, 75);
            this.btnPastGames.TabIndex = 0;
            this.btnPastGames.Text = "See Old Games";
            this.btnPastGames.UseVisualStyleBackColor = true;
            this.btnPastGames.Click += new System.EventHandler(this.btnPastGames_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(37, 148);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(198, 75);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnPastGames);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPastGames;
        private System.Windows.Forms.Button btnNewGame;
    }
}