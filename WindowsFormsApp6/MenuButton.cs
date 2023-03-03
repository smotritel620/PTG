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
    internal class MenuButton : Button
    {
        public MenuButton() : base()
        {
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.block;
            BackgroundImageLayout = ImageLayout.Stretch;
            ForeColor = Color.FromArgb(168, 203, 225);
            skin();
        }
        private void skin()
        {
            if (Shop.skin == 0)
            {
                BackgroundImage = Resources.block;
            }
            if (Shop.skin == 1 && Shop.skins[1] == true)
            {
                BackgroundImage = Resources.dark__1_;
            }
            if (Shop.skin == 2 && Shop.skins[2] == true)
            {
                BackgroundImage = Resources.nF;
            }
            if (Shop.skin == 3 && Shop.skins[3] == true)
            {
                BackgroundImage = Resources.ni;
            }
            if (Shop.skin == 4 && Shop.skins[4] == true)
            {
                BackgroundImage = Resources.nL;
            }
            if (Shop.skin == 5 && Shop.skins[5] == true)
            {
                BackgroundImage = Resources.nM1;
            }
            if (Shop.skin == 6 && Shop.skins[6] == true)
            {
                BackgroundImage = Resources.nM2;
            }
        }
    }
}
