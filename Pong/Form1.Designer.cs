namespace Pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.verticalTimer = new System.Windows.Forms.Timer(this.components);
            this.horizontalTimer = new System.Windows.Forms.Timer(this.components);
            this.inputTimer = new System.Windows.Forms.Timer(this.components);
            this.ballSprite = new System.Windows.Forms.PictureBox();
            this.paddleSprite = new System.Windows.Forms.PictureBox();
            this.pausePanel = new System.Windows.Forms.Panel();
            this.pasueLbl = new System.Windows.Forms.Label();
            this.collisionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ballSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleSprite)).BeginInit();
            this.pausePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // verticalTimer
            // 
            this.verticalTimer.Enabled = true;
            this.verticalTimer.Interval = 10;
            this.verticalTimer.Tick += new System.EventHandler(this.verticalTimer_Tick);
            // 
            // horizontalTimer
            // 
            this.horizontalTimer.Enabled = true;
            this.horizontalTimer.Interval = 10;
            this.horizontalTimer.Tick += new System.EventHandler(this.horizontalTimer_Tick);
            // 
            // inputTimer
            // 
            this.inputTimer.Enabled = true;
            this.inputTimer.Interval = 1;
            this.inputTimer.Tick += new System.EventHandler(this.inputTimer_Tick);
            // 
            // ballSprite
            // 
            this.ballSprite.Image = global::Pong.Properties.Resources.ball;
            this.ballSprite.Location = new System.Drawing.Point(382, 367);
            this.ballSprite.Name = "ballSprite";
            this.ballSprite.Size = new System.Drawing.Size(37, 54);
            this.ballSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ballSprite.TabIndex = 0;
            this.ballSprite.TabStop = false;
            // 
            // paddleSprite
            // 
            this.paddleSprite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.paddleSprite.Image = global::Pong.Properties.Resources.glasspaddle2;
            this.paddleSprite.Location = new System.Drawing.Point(301, 427);
            this.paddleSprite.Name = "paddleSprite";
            this.paddleSprite.Size = new System.Drawing.Size(199, 22);
            this.paddleSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paddleSprite.TabIndex = 1;
            this.paddleSprite.TabStop = false;
            // 
            // pausePanel
            // 
            this.pausePanel.BackColor = System.Drawing.Color.Gray;
            this.pausePanel.Controls.Add(this.pasueLbl);
            this.pausePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pausePanel.Location = new System.Drawing.Point(0, 0);
            this.pausePanel.Name = "pausePanel";
            this.pausePanel.Size = new System.Drawing.Size(800, 100);
            this.pausePanel.TabIndex = 2;
            this.pausePanel.Visible = false;
            // 
            // pasueLbl
            // 
            this.pasueLbl.AutoSize = true;
            this.pasueLbl.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pasueLbl.Location = new System.Drawing.Point(254, 22);
            this.pasueLbl.Name = "pasueLbl";
            this.pasueLbl.Size = new System.Drawing.Size(283, 54);
            this.pasueLbl.TabIndex = 3;
            this.pasueLbl.Text = "GAME PAUSED";
            // 
            // collisionTimer
            // 
            this.collisionTimer.Enabled = true;
            this.collisionTimer.Interval = 1;
            this.collisionTimer.Tick += new System.EventHandler(this.collisionTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pausePanel);
            this.Controls.Add(this.paddleSprite);
            this.Controls.Add(this.ballSprite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ballSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleSprite)).EndInit();
            this.pausePanel.ResumeLayout(false);
            this.pausePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ballSprite;
        private PictureBox paddleSprite;
        private System.Windows.Forms.Timer verticalTimer;
        private System.Windows.Forms.Timer horizontalTimer;
        private System.Windows.Forms.Timer inputTimer;
        private Panel pausePanel;
        private Label pasueLbl;
        private System.Windows.Forms.Timer collisionTimer;
    }
}