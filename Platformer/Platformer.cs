using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Platformer : Form
    {
        private List<Image> idleImages = new List<Image>();
        
        Image grassImg;
        Image groundImg;

        private int currentIdleIndex = 0;
        public Platformer()
        {
            InitializeComponent();

            this.DoubleBuffered= true;

            LoadResources();
        }

        private void Platformer_Load(object sender, EventArgs e)
        {

        }

        private void LoadResources()
        {
            for (int i = 0; i < 4; i++)
            {
                idleImages.Add(Image.FromFile(@"C:\My Works\Visual Studio\NDRWinFormGames\Platformer\Resources\PiedPiper\Walk\walk_" + (i + 1) + ".png"));
            }

            grassImg = Image.FromFile(@"C:\My Works\Visual Studio\NDRWinFormGames\Platformer\Resources\Environments\Grass.png");
            groundImg = Image.FromFile(@"C:\My Works\Visual Studio\NDRWinFormGames\Platformer\Resources\Environments\Ground.png");

        }

        private void Platformer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(idleImages[currentIdleIndex], new Point(0, 0));

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Image tile = groundImg;
                    e.Graphics.DrawImage(tile, new Point(i, (Height - 100) + j));
                }
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (currentIdleIndex >= 4 - 1)
                currentIdleIndex = 0;
            else
                currentIdleIndex++;

            this.Invalidate();
        }
    }
}
