using NDRFormsGameEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astroids
{
    public partial class Astroids : Form
    {
        Ship ship;

        public Astroids()
        {
            Game.CurrentForm = this;

            InitializeComponent();

            DoubleBuffered = true;

            ship = new Ship("Player Ship", playerShip);
            ship.Location = playerShip;
            //ship = (Ship)playerShip;
        }

        private void inputTimer_Tick(object sender, EventArgs e)
        {
            if (InputManager.ArrowRight && !Game.IsOnRightEdgeOfScreen(playerShip))
            {
                ship.HorizontalDir = 1;
            }
            else if (InputManager.ArrowLeft && ship.Left > 0)
            {
                ship.HorizontalDir = -1;
            }
            else
                ship.HorizontalDir = 0;

            if (InputManager.ArrowUp && !Game.IsOnTopEdgeOfScreen(playerShip))
            {
                ship.VerticalDir = -1;

            }
            else if (InputManager.ArrowDown && ship.Bottom > 0)
            {
                ship.VerticalDir = 1;
            }
            else
                ship.VerticalDir = 0;

            if (InputManager.Fire)
            {
                PictureBox newBullet = new PictureBox();
                newBullet.Image = Properties.Resources.laserBlue01;
                //newBullet.BackColor = Color.Blue;
                newBullet.Height = 20;
                newBullet.Width = 5;
                newBullet.Left = playerShip.Left + playerShip.Width / 2;
                newBullet.Top = playerShip.Top + playerShip.Height;
                newBullet.Tag = "bullet";
                newBullet.BringToFront();
                this.Controls.Add(newBullet);

            }

        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            if (InputManager.ArrowDown || InputManager.ArrowLeft || InputManager.ArrowRight || InputManager.ArrowUp)
                ship.UpdateMovement();
            else
                ship.Stop();

            
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (string)item?.Tag == "bullet")
                {
                    item.Top += 15;

                    if (item.Top > 900)
                    {
                        this.Controls.Remove(item);
                        item.Dispose();
                    }
                }
            }
        }

        private void Astroids_KeyDown(object sender, KeyEventArgs e)
        {
            InputManager.ArrowLeft = (e.KeyCode == Keys.Left);
            InputManager.ArrowRight = (e.KeyCode == Keys.Right);

            InputManager.ArrowUp = (e.KeyCode == Keys.Up);
            InputManager.ArrowDown = (e.KeyCode == Keys.Down);

            InputManager.Fire = (e.KeyCode == Keys.Space);
        }

        private void Astroids_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left))
                InputManager.ArrowLeft = false;

            else if ((e.KeyCode == Keys.Right))
                InputManager.ArrowRight = false;

            else if((e.KeyCode == Keys.Up))
                InputManager.ArrowUp = false;

            else if ((e.KeyCode == Keys.Down))
                InputManager.ArrowDown = false;

            else if ((e.KeyCode == Keys.Space))
                InputManager.Fire = false;
        }

       
    }
}
