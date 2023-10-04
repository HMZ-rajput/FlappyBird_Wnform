namespace Clumsy_Flora
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.HighScore = new System.Windows.Forms.Label();
            this.MusicOnOff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clumsy Flora";
            // 
            // Play
            // 
            this.Play.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(233, 333);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(161, 58);
            this.Play.TabIndex = 2;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.LoadGame);
            // 
            // Help
            // 
            this.Help.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.Location = new System.Drawing.Point(233, 446);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(161, 57);
            this.Help.TabIndex = 3;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.HelpGame);
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(233, 556);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(161, 58);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit :(";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitGame);
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore.Location = new System.Drawing.Point(13, 25);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(162, 27);
            this.HighScore.TabIndex = 5;
            this.HighScore.Text = "High Score : 99";
            // 
            // MusicOnOff
            // 
            this.MusicOnOff.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicOnOff.Location = new System.Drawing.Point(430, 12);
            this.MusicOnOff.Name = "MusicOnOff";
            this.MusicOnOff.Size = new System.Drawing.Size(142, 44);
            this.MusicOnOff.TabIndex = 6;
            this.MusicOnOff.Text = "Music: On";
            this.MusicOnOff.UseVisualStyleBackColor = true;
            this.MusicOnOff.Click += new System.EventHandler(this.MusicOnOff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clumsy_Flora.Properties.Resources.bird___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(278, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 72);
            this.label2.TabIndex = 7;
            this.label2.Text = "By:\r\nAnonymous | BSE 1B";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MusicOnOff);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label HighScore;
        private System.Windows.Forms.Button MusicOnOff;
        private System.Windows.Forms.Label label2;
    }
}