using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDRFormsGameEngine
{
    public class Game
    {
        public static Form CurrentForm { get; set; }


        public static bool IsOnRightEdgeOfScreen(PictureBox box)
        {
            return box.Left >= (CurrentForm.Width - box.Width);
        }
        public static bool IsOnTopEdgeOfScreen(PictureBox box)
        {
            return box.Bottom >= (CurrentForm.Height - box.Height);
        }
    }
}
