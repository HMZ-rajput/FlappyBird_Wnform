using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Clumsy_Flora
{
    public partial class Game : Form
    {

        int pipespeed = 10;
        int gravity = 7;
        int gravityn = 7;
        int score = 0;
        string temp = "";

        
        
        Random rnd = new Random();
        SoundPlayer S_gameover = new SoundPlayer(@"audio\gameover.wav");
        SoundPlayer S_jump = new SoundPlayer(@"audio\jump1.wav");
        



        public Game()
        {
            InitializeComponent();

            ControlBox = false;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            GameOverMenu.Hide();

            bird.Top += gravity;
            pipebtm.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            scoretxt.Text = "Score : "+Convert.ToString(score);


            if (pipebtm.Left < -50)
            {
                pipebtm.Left = rnd.Next(600,700);
                score++;
            }

            if (pipetop.Left < -50)
            {
                pipetop.Left = 550;
                score++;
            }

            if(score > 10)
            {
                gravityn = 10;
            }
            if(score > 20)
            {
                pipespeed = 13;
            }
            if(score > 30)
            {
                gravityn = 13;
            }
            if(score > 40)
            {
                pipespeed = 16;
            }

            if (bird.Bounds.IntersectsWith(pipebtm.Bounds) ||
               bird.Bounds.IntersectsWith(pipetop.Bounds) ||
               bird.Bounds.IntersectsWith(ground.Bounds) ||
               bird.Top < -30
               
               )
            {
                Game_Over();
            }
        }

        private void game_key_down(object sender, KeyEventArgs e)
        {
            if (temp == "")
            {
                if (e.KeyCode == Keys.Space)
                {
                    gravity = -gravityn;

                    S_jump.Play();
                }
            }
        }

        private void game_key_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = gravityn;
            }
        }

        private void Game_Over()
        {
            GameTimer.Stop();
            S_gameover.Play();
            temp = "gameover";

            scoretxt.Text ="Score : "+Convert.ToString(score)+"    Game Over!";
            CurrentScore.Text = "Your Score: " + score;
            

            string res = CheckScore(score);

            if(res == "nhighscore")
            {
                NewHighScore.Text = "New High Score: "+GetHighScore();
            }
            else
            {
                NewHighScore.Text = "High Score: "+GetHighScore();
            }

            GameOverMenu.Show();

        }

        private void RestartGame_Click(object sender, EventArgs e)
        {

            Application.Restart();
            
        }

        private void Exit_Gameover_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int GetHighScore()
        {
            var p = @"highscore.txt";

            var fs = new FileStream(p, FileMode.Open, FileAccess.Read);

            var sr = new StreamReader(fs);

            string scorestring = sr.ReadToEnd();

            fs.Dispose();

            int score = Convert.ToInt32(scorestring);

            return score;
        }

        private string CheckScore(int score)
        {
            string ans="";
            int phighscore = GetHighScore();

            if(score > phighscore)
            {
                var p = @"highscore.txt";

                var fs = new FileStream(p, FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(score);
                }

                ans = "nhighscore";
            }



            return ans;
        }



        private void ground_Click(object sender, EventArgs e)
        {

        }

        private void pipetop_Click(object sender, EventArgs e)
        {

        }

        private void scoretxt_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
