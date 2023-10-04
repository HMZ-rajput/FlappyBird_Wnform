using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Clumsy_Flora
{
    public partial class GameMenu : Form
    {
        string audio = "on";
        SoundPlayer S_background = new SoundPlayer(@"audio\background.wav");

        public GameMenu()
        {
            InitializeComponent();
            ControlBox = false;

            S_background.PlayLooping();


            HighScore.Text = "High Score: "+GetHighScore();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            S_background.Stop();

            Game GameWindow = new Game();

            GameWindow.Show();

            this.Close();


        }
        private void HelpGame(object sender, EventArgs e)
        {
            GameHelp help = new GameHelp();

            help.Show();

            S_background.Stop();

            this.Close();

        }
        private void ExitGame(object sender, EventArgs e)
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

        private void GameMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void MusicOnOff_Click(object sender, EventArgs e)
        {
            if (audio == "on")
            {
                S_background.Stop();

                MusicOnOff.Text = "Music: Off";
                audio = "off";
            }
            else
            {
                S_background.PlayLooping();

                MusicOnOff.Text = "Music: On";
                audio = "on";
            }
        }
    }
}
