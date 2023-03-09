using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using WindowsFormsApp6.Properties;

namespace WindowsFormsApp6
{
    class Shop : Form
    {
        ShopP shopP;
        MenuButton shopB;
        public static int skin = 0;
        private string skinT = "Активировано";
        public static List<bool> skins = new List<bool>();
        List<bool> skins_truf = new List<bool>();
        Label ballL_shop;
        MenuButton shopR;
        string ballL_shop_text = "" + Form1.ball;
        public static bool Format { get; set; }
        public Shop() : base()
        {
            Format = false;
            skins.Add(true);
            skins.Add(false);
            skins.Add(false);
            skins.Add(false);
            skins.Add(false);
            skins.Add(false);
            skins.Add(false);
            skins.Add(false);
            skins.Add(false);
            skins.Add(false);
            skins_truf.Add(true);
            skins_truf.Add(false);
            skins_truf.Add(false);
            skins_truf.Add(false);
            skins_truf.Add(false);
            skins_truf.Add(false);
            skins_truf.Add(false);
            skins_truf.Add(false);
            skins_truf.Add(false);
            skins_truf.Add(false);
            Width = 620;
            Height = 877;
            BackgroundImage = Resources.back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ballL_shop = new Label()
            {
                Text = ballL_shop_text,
                Location = new Point(10, 10),
                BackColor = Color.Transparent,
            };
            Controls.Add(ballL_shop);
            shopP = new ShopP()
            {
                BackgroundImage = Resources.startmenu,
                BackgroundImageLayout = ImageLayout.Stretch
            };
            shopB = new MenuButton()
            {
                Width = 580,
                Height = 70,
                Location = new Point(10, 660),
                Text = skinT
            };
            shopR = new MenuButton()
            {
                Width = 580,
                Height = 70,
                Location = new Point(10, 740),
                Text = "СБРОС"
            };
            Controls.Add(shopP);
            Controls.Add(shopB);
            Controls.Add(shopR);
            shopR.Click += ShopR_Click;
            shopB.Click += ShopB_Click;
            shopP.Click += ShopP_Click;
        }

        private void ShopR_Click(object sender, EventArgs e)
        {
            Form1.ball = 0;
            skin = 0;
            Format = true;
            skins.ForEach(skin => skin = false);
            skins[0] = true;
            skins_truf.ForEach(skin => skin = false);
            skins_truf[0] = true;
            Status status = new Status();
            BinaryFormatter narnia = new BinaryFormatter();
            FileStream stream = new FileStream("board.ptg", FileMode.Create);

            narnia.Serialize(stream, status);
            stream.Close();
        }

        private void ShopB_Click(object sender, EventArgs e)
        {
            if (skins_truf[1] == false && skin == 1 && Form1.ball >= 200)
            {
                skins[1] = true;
                skins_truf[1] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
                Form1.ball -= 200;
                ballL_shop_text = "" + Form1.ball;
                ballL_shop.Text = ballL_shop_text;
            }
            else if (skins_truf[1] == true && skin == 1)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[1] =  false;
            }
            if (skins_truf[2] == false && skin == 2 && Form1.ball >= 400)
            {
                skins[2] = true;
                skins_truf[2] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
                Form1.ball -= 400;
                ballL_shop_text = "" + Form1.ball;
                ballL_shop.Text = ballL_shop_text;
            }
            else if (skins_truf[2] == true && skin == 2)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[2] = false;
            }
            if (skins_truf[3] == false && skin == 3 && Form1.ball >= 600)
            {
                skins[3] = true;
                skins_truf[3] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
                Form1.ball -= 600;
                ballL_shop_text = "" + Form1.ball;
                ballL_shop.Text = ballL_shop_text;
            }
            else if (skins_truf[3] == true && skin == 3)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[3] = false;
            }
            if (skins_truf[4] == false && skin == 4 && Form1.ball >= 800)
            {
                skins[4] = true;
                skins_truf[4] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
                Form1.ball -= 800;
                ballL_shop_text = "" + Form1.ball;
                ballL_shop.Text = ballL_shop_text;
            }
            else if (skins_truf[4] == true && skin == 4)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[4] = false;
            }
            if (skins_truf[5] == false && skin == 5 && Form1.ball >= 1000)
            {
                skins[5] = true;
                skins_truf[5] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
                Form1.ball -= 1000;
                ballL_shop_text = "" + Form1.ball;
                ballL_shop.Text = ballL_shop_text;
            }
            else if (skins_truf[5] == true && skin == 5)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[5] = false;
            }
            if (skins_truf[6] == false && skin == 6 && Form1.ball >= 1200)
            {
                skins[6] = true;
                skins_truf[6] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
                Form1.ball -= 1200;
                ballL_shop_text = "" + Form1.ball;
                ballL_shop.Text = ballL_shop_text;
            }
            else if (skins_truf[6] == true && skin == 6)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[6] = false;
            }
            if (skins_truf[7] == false && skin == 7 && Form1.ball >= 1400 && skins_truf[6] == true && skins_truf[5] == true)
            {
                skins[7] = true;
                skins_truf[7] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
                Form1.ball -= 1400;
                ballL_shop_text = "" + Form1.ball;
                ballL_shop.Text = ballL_shop_text;
            }
            else if (skins_truf[7] == true && skin == 7)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[6] = false;
            }
            if (skins_truf[8] == false && skin == 8 && Form1.ball >= 1600 && skins_truf[1] == true && skins_truf[2] == true && skins_truf[3] == true && skins_truf[4] == true && skins_truf[5] == true && skins_truf[6] == true && skins_truf[7] == true)
            {
                skins[8] = true;
                skins_truf[8] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
                Form1.ball -= 1600;
                ballL_shop_text = "" + Form1.ball;
                ballL_shop.Text = ballL_shop_text;
            }
            else if (skins_truf[8] == true && skin == 8)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[8] = false;
            }
            if (skins_truf[9] == false && skin == 9 && Form1.ball >= 1800 && skins_truf[1] == true && skins_truf[2] == true && skins_truf[3] == true && skins_truf[4] == true && skins_truf[5] == true && skins_truf[6] == true && skins_truf[7] == true && skins_truf[8] == true)
            {
                skins[9] = true;
                skins_truf[9] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
                Form1.ball -= 1800;
                ballL_shop_text = "" + Form1.ball;
                ballL_shop.Text = ballL_shop_text;
            }
            else if (skins_truf[9] == true && skin == 9)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[9] = false;
            }
        }

        private void ShopP_Click(object sender, EventArgs e)
        {
            if (skin != 10)
            {
                skin++;
            }
            if (skin == 0) 
            { 
                shopP.BackgroundImage = Resources.startmenu;
                skinT = "Активировать";
                shopB.Text = skinT;
            }
            if (skin == 1)
            {
                shopP.BackgroundImage = Resources.startmenuD;
                if (skins[1] == false)
                {
                    skinT = "купить:200b";
                    shopB.Text = skinT;
                }
                else
                {
                    skinT = "Активировать";
                    shopB.Text = skinT;
                }
            }
            else if (skin == 2)
            {
                shopP.BackgroundImage = Resources.startmenuF;
                if (skins[2] == false)
                {
                    skinT = "купить:400b";
                    shopB.Text = skinT;
                }
                else
                {
                    skinT = "Активировать";
                    shopB.Text = skinT;
                }
            }
            else if (skin == 3)
            {
                shopP.BackgroundImage = Resources.startmenui;
                if (skins[3] == false)
                {
                    skinT = "купить:600b";
                    shopB.Text = skinT;
                }
                else
                {
                    skinT = "Активировать";
                    shopB.Text = skinT;
                }
            }
            else if (skin == 4)
            {
                shopP.BackgroundImage = Resources.startmenuL;
                if (skins[4] == false)
                {
                    skinT = "купить:800b";
                    shopB.Text = skinT;
                }
                else
                {
                    skinT = "Активировать";
                    shopB.Text = skinT;
                }
            }
            else if (skin == 5)
            {
                shopP.BackgroundImage = Resources.startmenuM1;
                if (skins[5] == false)
                {
                    skinT = "купить:1000b";
                    shopB.Text = skinT;
                }
                else
                {
                    skinT = "Активировать";
                    shopB.Text = skinT;
                }
            }
            else if (skin == 6)
            {
                shopP.BackgroundImage = Resources.startmenuM2;
                if (skins[6] == false)
                {
                    skinT = "купить:1200b";
                    shopB.Text = skinT;
                }
                else
                {
                    skinT = "Активировать";
                    shopB.Text = skinT;
                }
            }
            else if (skin == 7)
            {
                shopP.BackgroundImage = Resources.startmenuSM;
                if (skins[7] == false)
                {
                    skinT = "купить:1400b";
                    shopB.Text = skinT;
                }
                else
                {
                    skinT = "Активировать";
                    shopB.Text = skinT;
                }
            }
            else if (skin == 8)
            {
                shopP.BackgroundImage = Resources.startmenuWt2;
                if (skins[8] == false)
                {
                    skinT = "купить:1600b";
                    shopB.Text = skinT;
                }
                else
                {
                    skinT = "Активировать";
                    shopB.Text = skinT;
                }
            }
            else if (skin == 9)
            {
                shopP.BackgroundImage = Resources.startmenuC;
                if (skins[9] == false)
                {
                    skinT = "купить:1800b";
                    shopB.Text = skinT;
                }
                else
                {
                    skinT = "Активировать";
                    shopB.Text = skinT;
                }
            }
            else if (skin == 10)
            {
                skin = 0;
                shopP.BackgroundImage = Resources.startmenu;
                skinT = "Активировать";
                shopB.Text = skinT;
            }
        }
    }
}
