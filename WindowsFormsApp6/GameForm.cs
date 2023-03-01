using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp6
{
    class GameForm : Form
    {
        Pplayer player1;
        Pplayer player2;
        Enemy enemy1;
        int R = 220; 
        double timerT = 0.25;
        double timerT2 = 0.25;
        int centerX, centerY;
        System.Windows.Forms.Timer timerEM;
        System.Windows.Forms.Timer timerbal;
        Random enemy_random = new Random();
        int enemy_random2 = 0;
        public int ball = 0;
        Label ballL;
        public GameForm() : base()
        {
            Width = 620;
            Height = 877;
            ballL = new Label()
            {
                Text = "" + ball,
                Location = new Point(10, 10),
                BackColor = Color.Transparent
            };
            Controls.Add(ballL);
            BackgroundImage = Resources.back;
            BackgroundImageLayout = ImageLayout.Stretch;
            WindowState = FormWindowState.Maximized;
            timerEM = new System.Windows.Forms.Timer();
            timerEM.Tick += TimerEM_Tick;
            timerEM.Interval = 1;
            timerEM.Start();
            timerbal = new System.Windows.Forms.Timer();
            timerbal.Tick += Timerbal_Tick;
            timerbal.Interval = 1;
            timerbal.Start();
            centerX = Screen.GetWorkingArea(this).Width / 2;
            centerY = Screen.GetWorkingArea(this).Height - 280;
            int cY = Screen.GetWorkingArea(this).Height;
            player1 = new Pplayer()
            {
                Location = new Point(centerX, centerY),
            };
            Controls.Add(player1);
            player2 = new Pplayer()
            {
                Location = new Point(centerX, centerY),
            };
            Controls.Add(player2);
            enemy1 = new Enemy()
            {
                Location = new Point(centerX + 50, cY - 700)
            };
            Controls.Add(enemy1);
            KeyDown += GameForm_KeyDown;
            Skin();
        }

        private void Timerbal_Tick(object sender, EventArgs e)
        {
            ball++;
            ballL.Text = "" + ball;
        }

        private void TimerEM_Tick(object sender, EventArgs e)
        {
            if (enemy1.Bounds.IntersectsWith(player1.Bounds) || enemy1.Bounds.IntersectsWith(player2.Bounds))
            {
                KeyDown -= GameForm_KeyDown;
                timerbal.Stop();
                timerEM.Stop();
            }
            enemy1.Location = new Point(enemy1.Location.X, enemy1.Location.Y + 25);
            if (enemy1.Location.Y > Screen.GetWorkingArea(this).Height - 200)
            {
                enemy_random2 = enemy_random.Next(0, centerX * 2 - 300);
                enemy1.Location = new Point(enemy_random2, 0);
            }
        }
        private void Skin()
        {
            if (Shop.skin == 1 && Shop.skins[1] == true)
            {
                player1.BackgroundImage = Resources._D;
                player2.BackgroundImage = Resources._D;
                BackgroundImage = Resources.dark__1_;
                enemy1.BackgroundImage = Resources.playerD;
            }
            if (Shop.skin == 2 && Shop.skins[2] == true)
            {
                player1.BackgroundImage = Resources._F__1_;
                player2.BackgroundImage = Resources._F__1_;
                BackgroundImage = Resources.nF;
                enemy1.BackgroundImage = Resources.playerF__1_;
            }
            if (Shop.skin == 3 && Shop.skins[3] == true)
            {
                player1.BackgroundImage = Resources.playeri;
                player2.BackgroundImage = Resources.playeri;
                BackgroundImage = Resources.ni;
                enemy1.BackgroundImage = Resources.playeri;
            }
            if (Shop.skin == 4 && Shop.skins[4] == true)
            {
                player1.BackgroundImage = Resources._L;
                player2.BackgroundImage = Resources._L;
                BackgroundImage = Resources.nL;
                enemy1.BackgroundImage = Resources.playerL;
            }
            if (Shop.skin == 5 && Shop.skins[5] == true)
            {
                player1.BackgroundImage = Resources._M1__1_;
                player2.BackgroundImage = Resources._M1__1_;
                BackgroundImage = Resources.nM1;
                enemy1.BackgroundImage = Resources.playerM1;
            }
            if (Shop.skin == 6 && Shop.skins[6] == true)
            {
                player1.BackgroundImage = Resources._M2;
                player2.BackgroundImage = Resources._M2;
                BackgroundImage = Resources.nM2;
                enemy1.BackgroundImage = Resources.playerM2;
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                int x = (int)(centerX + R * Math.Sin(timerT));
                int y = (int)(centerY + R * Math.Cos(timerT));
                timerT += 0.25;
                player1.Location = new Point(x, y);
                x = (int)(centerX - R * Math.Sin(timerT2));
                y = (int)(centerY - R * Math.Cos(timerT2));
                timerT2 += 0.25;
                player2.Location = new Point(x, y);
            }
            else if (e.KeyCode == Keys.D)
            {
                int x = (int)(centerX + R * Math.Sin(timerT));
                int y = (int)(centerY + R * Math.Cos(timerT));
                timerT -= 0.25;
                player1.Location = new Point(x, y);
                x = (int)(centerX - R * Math.Sin(timerT2));
                y = (int)(centerY - R * Math.Cos(timerT2));
                timerT2 -= 0.25;
                player2.Location = new Point(x, y);
            }
        }
    }
}
