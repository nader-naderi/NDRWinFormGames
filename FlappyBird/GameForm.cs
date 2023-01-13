using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class GameForm : Form
    {
        // TODO: Implement Parralell scrolling.
        //Image layer_1 = Properties.Resources.background;

        //int b1 = 0, b2 = 800;
        int jumpForce = 10;
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;


        public GameForm()
        {
            InitializeComponent();
        }

        private void scrollingBGTimer_Tick(object sender, EventArgs e)
        {

        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(layer_1, b1, 0);
            //e.Graphics.DrawImage(layer_1, b2, 0);
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            player.Top += gravity;
            player.Left += pipeSpeed;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                player.Top += jumpForce;
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
