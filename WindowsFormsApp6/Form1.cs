using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Properties;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        MenuButton button_start;
        MenuButton Exit;
        SoundPlayer bClick;
        GameForm game;
        Shop shop;
        public Form1()
        {
            InitializeComponent();
            Width = 310;
            Height = 458;
            button1.Location = new Point(216, 13);
            bClick = new SoundPlayer(Resources.converted_WaterDrop);
            button1.Click += Button1_Click;
            button_start = new MenuButton()
            {
                Location = new Point(85, 109),
                Text = "start",
                Width = 156,
                Height = 38
            };
            Controls.Add(button_start);
            button_start.Click += Button_start_Click;
            Exit = new MenuButton()
            {
                Location = new Point(92, 226),
                Text = "Exit",
                Width = 156,
                Height = 38
            };
            Controls.Add(Exit);
            Exit.Click += Exit_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ButtonClick();
            shop = new Shop();
            shop.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ButtonClick();
            System.Threading.Thread.Sleep(690);
            Close();
        }
        private void skin()
        {
            if (Shop.skin == 1 && Shop.skins[1] == true)
            {
                BackgroundImage = Resources.startmenuD;
            }
            if (Shop.skin == 2 && Shop.skins[2] == true)
            {
                BackgroundImage = Resources.startmenuF;
            }
            if (Shop.skin == 3 && Shop.skins[3] == true)
            {
                BackgroundImage = Resources.startmenui;
            }
            if (Shop.skin == 4 && Shop.skins[4] == true)
            {
                BackgroundImage = Resources.startmenuL;
            }
            if (Shop.skin == 5 && Shop.skins[5] == true)
            {
                BackgroundImage = Resources.startmenuM1;
            }
            if (Shop.skin == 6 && Shop.skins[6] == true)
            {
                BackgroundImage = Resources.startmenuM2;
            }
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            ButtonClick();
            game = new GameForm();
            game.FormClosed += Game_FormClosed;
            Hide();
            game.Show();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void ButtonClick()
        {
            bClick.Play();
        }
    }
}
