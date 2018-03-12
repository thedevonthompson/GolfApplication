namespace GolfApp
{
    partial class frmNewGame
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
            this.labHole = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFinishGame = new System.Windows.Forms.Button();
            this.lstDrive = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFairway = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstGreenShots = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTotalShots = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labHole
            // 
            this.labHole.AutoSize = true;
            this.labHole.Location = new System.Drawing.Point(12, 9);
            this.labHole.Name = "labHole";
            this.labHole.Size = new System.Drawing.Size(32, 13);
            this.labHole.TabIndex = 0;
            this.labHole.Text = "Hole:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(656, 156);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(72, 50);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(15, 156);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(64, 50);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFinishGame
            // 
            this.btnFinishGame.Location = new System.Drawing.Point(295, 289);
            this.btnFinishGame.Name = "btnFinishGame";
            this.btnFinishGame.Size = new System.Drawing.Size(159, 61);
            this.btnFinishGame.TabIndex = 4;
            this.btnFinishGame.Text = "Finish Game";
            this.btnFinishGame.UseVisualStyleBackColor = true;
            this.btnFinishGame.Visible = false;
            this.btnFinishGame.Click += new System.EventHandler(this.btnFinishGame_Click);
            // 
            // lstDrive
            // 
            this.lstDrive.FormattingEnabled = true;
            this.lstDrive.Items.AddRange(new object[] {
            "Hook",
            "Slice",
            "Straight"});
            this.lstDrive.Location = new System.Drawing.Point(114, 64);
            this.lstDrive.Name = "lstDrive";
            this.lstDrive.Size = new System.Drawing.Size(93, 95);
            this.lstDrive.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Drive:";
            // 
            // lstFairway
            // 
            this.lstFairway.FormattingEnabled = true;
            this.lstFairway.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.lstFairway.Location = new System.Drawing.Point(238, 64);
            this.lstFairway.Name = "lstFairway";
            this.lstFairway.Size = new System.Drawing.Size(99, 95);
            this.lstFairway.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "On Fairway?";
            // 
            // lstGreenShots
            // 
            this.lstGreenShots.FormattingEnabled = true;
            this.lstGreenShots.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.lstGreenShots.Location = new System.Drawing.Point(368, 64);
            this.lstGreenShots.Name = "lstGreenShots";
            this.lstGreenShots.Size = new System.Drawing.Size(100, 95);
            this.lstGreenShots.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Shots To Green:";
            // 
            // lstTotalShots
            // 
            this.lstTotalShots.FormattingEnabled = true;
            this.lstTotalShots.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.lstTotalShots.Location = new System.Drawing.Point(499, 64);
            this.lstTotalShots.Name = "lstTotalShots";
            this.lstTotalShots.Size = new System.Drawing.Size(97, 95);
            this.lstTotalShots.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total Shots:";
            // 
            // frmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 372);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstTotalShots);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstGreenShots);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstFairway);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDrive);
            this.Controls.Add(this.btnFinishGame);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.labHole);
            this.Name = "frmNewGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.frmNewGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHole;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFinishGame;
        private System.Windows.Forms.ListBox lstDrive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFairway;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstGreenShots;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTotalShots;
        private System.Windows.Forms.Label label4;
    }
}