using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clumsy_Flora
{
    public partial class GameHelp : Form
    {
        public GameHelp()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            GameMenu gameMenu = new GameMenu();
            gameMenu.Show();
            
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
