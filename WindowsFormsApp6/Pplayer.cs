using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Properties;

namespace WindowsFormsApp6
{
    class Pplayer : PictureBox
    {
        public Pplayer() : base()
        { 
            Width = 60;
            Height = 60;
            BackgroundImage = Resources.player;
            BackgroundImageLayout = ImageLayout.Stretch;
            BackColor = Color.Transparent;
        }
    }
}
