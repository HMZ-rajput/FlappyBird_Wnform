namespace Clumsy_Flora
{
    partial class GameOver
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Retry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::Clumsy_Flora.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-22, 583);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(736, 96);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 67);
            this.label1.TabIndex = 5;
            this.label1.Text = "Game Over";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(212, 437);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(161, 58);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit :(";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Retry
            // 
            this.Retry.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retry.Location = new System.Drawing.Point(212, 301);
            this.Retry.Name = "Retry";
            this.Retry.Size = new System.Drawing.Size(161, 58);
            this.Retry.TabIndex = 7;
            this.Retry.Text = "Retry";
            this.Retry.UseVisualStyleBackColor = true;
            this.Retry.Click += new System.EventHandler(this.Retry_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.Retry);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ground);
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver";
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Retry;
    }
}