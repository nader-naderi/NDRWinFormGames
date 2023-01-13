namespace FlappyBird
{
    partial class GameForm
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
            this.scrollingBGTimer = new System.Windows.Forms.Timer(this.components);
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // scrollingBGTimer
            // 
            this.scrollingBGTimer.Enabled = true;
            this.scrollingBGTimer.Interval = 10;
            this.scrollingBGTimer.Tick += new System.EventHandler(this.scrollingBGTimer_Tick);
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 10;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.BackgroundImage = global::FlappyBird.Properties.Resources.planeBlue1;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.player.Location = new System.Drawing.Point(257, 268);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(103, 81);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer scrollingBGTimer;
        private System.Windows.Forms.Timer gameLoop;
        private PictureBox player;
    }
}