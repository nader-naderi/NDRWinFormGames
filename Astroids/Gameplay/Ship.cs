
using NDRFormsGameEngine;

using System;

namespace Astroids
{
    public class Ship : GameObject
    {
        public Ship(string name, PictureBox visual) : base(name)
        {
            this.Visual = visual;
        }

        public int Speed { get; private set; } = 4;
        public int Score { get; set; }

        public int VerticalDir { get; set; } = 1;
        public int HorizontalDir { get; set; } = 1;
        public PictureBox Visual { get; }   

        public void UpdateMovement(int dx, int dy)
        {
            VerticalDir = dy;
            HorizontalDir = dx;
            UpdateMovement();
        }

        public void UpdateMovement()
        {
            MoveHorizontaly();
            MoveVerticaly();

            Location = Visual.Location;
        }

        public void MoveHorizontaly()
        {
            Visual.Left += (HorizontalDir * Speed);
        }

        public void MoveVerticaly()
        {
            Visual.Top += (VerticalDir * Speed);
        }

        public void MoveHorizontaly(int dx)
        {
            HorizontalDir = dx;
            Visual.Left += (HorizontalDir * Speed);
        }

        public void MoveVerticaly(int dy)
        {
            VerticalDir = dy;
            Visual.Top += (VerticalDir * Speed);
        }
        public void Stop()
        {
            HorizontalDir = 0;
            VerticalDir = 0;
        }

        public PictureBox Fire()
        {
            PictureBox newBullet = new PictureBox();
            newBullet.Image = Properties.Resources.laserBlue01;
            //newBullet.BackColor = Color.Blue;
            newBullet.Height = 10;
            newBullet.Width = 5;
            newBullet.Left = Left + Width / 2;
            newBullet.Left = Top + Height;
            newBullet.Tag = "bullet";
            newBullet.BringToFront();
            MessageBox.Show(newBullet.Name);
            return newBullet;
        }
    }
}
