namespace Astroids
{
    partial class Astroids
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
            this.playerShip = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playerShip
            // 
            this.playerShip.Image = global::Astroids.Properties.Resources.playerShip3_blue;
            this.playerShip.Location = new System.Drawing.Point(455, 600);
            this.playerShip.Name = "playerShip";
            this.playerShip.Size = new System.Drawing.Size(70, 50);
            this.playerShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerShip.TabIndex = 0;
            this.playerShip.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Astroids.Properties.Resources.BG;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1008, 729);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tickTimer
            // 
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // Astroids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.playerShip);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Astroids";
            this.Text = "Astroids";
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox playerShip;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer tickTimer;
    }
}