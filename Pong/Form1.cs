namespace Pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateBlocksGrid();

            ballFirstPos = ballSprite.Location;
            paddleFirstPos = paddleSprite.Location;
        }

        private void GenerateBlocksGrid()
        {
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 10; j++)
                    CreateBlock(i, j);
        }

        private void CreateBlock(int i, int j)
        {
            PictureBox newBlock = new PictureBox();
            newBlock.Size = new Size(50, 20);
            newBlock.Location = new Point(i * newBlock.Size.Width, j * newBlock.Size.Height);
            newBlock.BackColor = colors[random.Next(0, colors.Length)];
            newBlock.BorderStyle = BorderStyle.Fixed3D;
            blocks.Add(newBlock);
            Controls.Add(newBlock);
        }

        private Random random = new Random();
        private Color[] colors = new Color[5]
        { Color.Red, Color.Yellow, Color.Pink, Color.Green, Color.Blue };

        private int speed = 3;
        private int verticalDir = +1;
        private int horizontalDir = +1;

        private int paddleSpeed = 2;
        private bool left;
        private bool right;
        private bool isGameOver;

        private List<PictureBox> blocks = new List<PictureBox>();

        Point ballFirstPos;
        Point paddleFirstPos;

        public bool IsPaused
        {
            get
            {
                return !pausePanel.Visible;
            }
            set
            {
                pausePanel.Visible = !value;
            }
        }

        private void verticalTimer_Tick(object sender, EventArgs e)
        {
            if (ballSprite.Top < 0)
            {
                verticalDir = +1;
            }
            //else if (ballSprite.Top > (this.Height - ballSprite.Height - paddleSprite.Height))
            else if (ballSprite.Bounds.IntersectsWith(paddleSprite.Bounds))
            {
                verticalDir = -1;
            }
            else if (ballSprite.Top > (Height - ballSprite.Height - paddleSprite.Height))
            {
                if (ballSprite.Left < paddleSprite.Left ||
                    ((ballSprite.Left + ballSprite.Width) > (paddleSprite.Left + paddleSprite.Width)))
                {
                    TogglePause(false, "Game Over");
                    HandleGameOver();
                }
            }

            ballSprite.Top += (verticalDir * speed);
        }

        private void HandleGameOver()
        {
            isGameOver = true;

            var result = MessageBox.Show(this, "Game Over, Try Again?", "Help Caption", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Reset the game.
                isGameOver = false;
                paddleSprite.Location = paddleFirstPos;
                ballSprite.Location = ballFirstPos;
                GenerateBlocksGrid();
                TogglePause();
            }
            else
            {
                Application.Exit();
            }
        }

        private void horizontalTimer_Tick(object sender, EventArgs e)
        {
            if (ballSprite.Left < 0)
            {
                horizontalDir = +1;
            }
            else if (ballSprite.Left > (this.Width - ballSprite.Width))
            {
                horizontalDir = -1;
            }
            ballSprite.Left += (horizontalDir * speed);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            HandlePauseInput(e);
            HandleMovementInput(e);
        }

        private void HandleMovementInput(KeyEventArgs e)
        {
            left = (e.KeyCode == Keys.Left);
            right = (e.KeyCode == Keys.Right);
        }

        private void HandlePauseInput(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                TogglePause();
        }

        private void TogglePause()
        {
            IsPaused = !IsPaused;
            horizontalTimer.Enabled = verticalTimer.Enabled = IsPaused;
        }

        private void TogglePause(bool value, string message = "")
        {
            IsPaused = value;
            horizontalTimer.Enabled = verticalTimer.Enabled = IsPaused;

            if (message != "")
                pasueLbl.Text = message;
        }

        private void inputTimer_Tick(object sender, EventArgs e)
        {
            UpdatePaddleInput();
        }

        private void UpdatePaddleInput()
        {
            if (right && paddleSprite.Left < (Width - paddleSprite.Width))
            {
                paddleSprite.Left += paddleSpeed;
            }
            if (left && paddleSprite.Left > 0)
            {
                paddleSprite.Left -= paddleSpeed;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = false;
            else if (e.KeyCode == Keys.Left)
                left = false;
        }

        public static bool CollisionDetection(Rectangle rect1, Rectangle rect2)
            => rect1.X < (rect2.X + rect2.Width) && (rect1.X + rect1.Width) > rect2.X &&
            rect1.Y < (rect2.Y + rect2.Height) && (rect1.Height + rect1.Y) > rect2.Y;

        private void collisionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < blocks.Count; i++)
            {
                if (ballSprite.Bounds.IntersectsWith(blocks[i].Bounds))
                {
                    Controls.Remove(blocks[i]);
                }
            }
        }
    }
}