namespace GolfApp
{
    partial class frmOldGames
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
            this.lstOldGames = new System.Windows.Forms.ListBox();
            this.btnViewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOldGames
            // 
            this.lstOldGames.FormattingEnabled = true;
            this.lstOldGames.Location = new System.Drawing.Point(56, 37);
            this.lstOldGames.Name = "lstOldGames";
            this.lstOldGames.Size = new System.Drawing.Size(163, 160);
            this.lstOldGames.TabIndex = 0;
            // 
            // btnViewGame
            // 
            this.btnViewGame.Location = new System.Drawing.Point(102, 213);
            this.btnViewGame.Name = "btnViewGame";
            this.btnViewGame.Size = new System.Drawing.Size(75, 23);
            this.btnViewGame.TabIndex = 1;
            this.btnViewGame.Text = "View Game";
            this.btnViewGame.UseVisualStyleBackColor = true;
            this.btnViewGame.Click += new System.EventHandler(this.btnViewGame_Click);
            // 
            // frmOldGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnViewGame);
            this.Controls.Add(this.lstOldGames);
            this.Name = "frmOldGames";
            this.Text = "frmOldGames";
            this.Load += new System.EventHandler(this.frmOldGames_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOldGames;
        private System.Windows.Forms.Button btnViewGame;
    }
}