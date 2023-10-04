namespace Clumsy_Flora
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.scoretxt = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameOverMenu = new System.Windows.Forms.GroupBox();
            this.NewHighScore = new System.Windows.Forms.Label();
            this.CurrentScore = new System.Windows.Forms.Label();
            this.Exit_Gameover = new System.Windows.Forms.Label();
            this.RestartGame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipebtm = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.GameOverMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebtm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // scoretxt
            // 
            this.scoretxt.AutoSize = true;
            this.scoretxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.scoretxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretxt.Location = new System.Drawing.Point(25, 621);
            this.scoretxt.Name = "scoretxt";
            this.scoretxt.Size = new System.Drawing.Size(93, 27);
            this.scoretxt.TabIndex = 4;
            this.scoretxt.Text = "Score: 1";
            this.scoretxt.Click += new System.EventHandler(this.scoretxt_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // GameOverMenu
            // 
            this.GameOverMenu.BackColor = System.Drawing.Color.Transparent;
            this.GameOverMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameOverMenu.Controls.Add(this.NewHighScore);
            this.GameOverMenu.Controls.Add(this.CurrentScore);
            this.GameOverMenu.Controls.Add(this.Exit_Gameover);
            this.GameOverMenu.Controls.Add(this.RestartGame);
            this.GameOverMenu.Controls.Add(this.label1);
            this.GameOverMenu.Location = new System.Drawing.Point(66, 114);
            this.GameOverMenu.Name = "GameOverMenu";
            this.GameOverMenu.Size = new System.Drawing.Size(443, 295);
            this.GameOverMenu.TabIndex = 5;
            this.GameOverMenu.TabStop = false;
            this.GameOverMenu.Text = " ";
            this.GameOverMenu.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NewHighScore
            // 
            this.NewHighScore.AutoSize = true;
            this.NewHighScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewHighScore.Location = new System.Drawing.Point(263, 255);
            this.NewHighScore.Name = "NewHighScore";
            this.NewHighScore.Size = new System.Drawing.Size(129, 23);
            this.NewHighScore.TabIndex = 4;
            this.NewHighScore.Text = "High Score :99";
            this.NewHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScore
            // 
            this.CurrentScore.AutoSize = true;
            this.CurrentScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentScore.Location = new System.Drawing.Point(35, 255);
            this.CurrentScore.Name = "CurrentScore";
            this.CurrentScore.Size = new System.Drawing.Size(129, 23);
            this.CurrentScore.TabIndex = 3;
            this.CurrentScore.Text = "Your Score: 99";
            // 
            // Exit_Gameover
            // 
            this.Exit_Gameover.AutoSize = true;
            this.Exit_Gameover.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Gameover.Location = new System.Drawing.Point(145, 184);
            this.Exit_Gameover.Name = "Exit_Gameover";
            this.Exit_Gameover.Size = new System.Drawing.Size(143, 30);
            this.Exit_Gameover.TabIndex = 2;
            this.Exit_Gameover.Text = "Exit Game :(";
            this.Exit_Gameover.Click += new System.EventHandler(this.Exit_Gameover_Click);
            // 
            // RestartGame
            // 
            this.RestartGame.AutoSize = true;
            this.RestartGame.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartGame.Location = new System.Drawing.Point(128, 136);
            this.RestartGame.Name = "RestartGame";
            this.RestartGame.Size = new System.Drawing.Size(179, 30);
            this.RestartGame.TabIndex = 1;
            this.RestartGame.Text = "Restart Game :)";
            this.RestartGame.Click += new System.EventHandler(this.RestartGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over";
            // 
            // ground
            // 
            this.ground.Image = global::Clumsy_Flora.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-22, 583);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(736, 96);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.ground_Click);
            // 
            // pipebtm
            // 
            this.pipebtm.BackColor = System.Drawing.Color.Transparent;
            this.pipebtm.Image = global::Clumsy_Flora.Properties.Resources.pipe;
            this.pipebtm.Location = new System.Drawing.Point(365, 329);
            this.pipebtm.Name = "pipebtm";
            this.pipebtm.Size = new System.Drawing.Size(80, 319);
            this.pipebtm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebtm.TabIndex = 2;
            this.pipebtm.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.BackColor = System.Drawing.Color.Transparent;
            this.pipetop.Image = global::Clumsy_Flora.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(447, -60);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(80, 281);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 1;
            this.pipetop.TabStop = false;
            this.pipetop.Click += new System.EventHandler(this.pipetop_Click);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::Clumsy_Flora.Properties.Resources.bird___Copy;
            this.bird.Location = new System.Drawing.Point(40, 232);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(60, 48);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.GameOverMenu);
            this.Controls.Add(this.scoretxt);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.pipebtm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clumsy Flora";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_key_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_key_up);
            this.GameOverMenu.ResumeLayout(false);
            this.GameOverMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebtm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox pipebtm;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoretxt;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.GroupBox GameOverMenu;
        private System.Windows.Forms.Label Exit_Gameover;
        private System.Windows.Forms.Label RestartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NewHighScore;
        private System.Windows.Forms.Label CurrentScore;
    }
}

