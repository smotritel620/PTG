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
    class Shop : Form
    {
        ShopP shopP;
        MenuButton shopB;
        public static int skin = 0;
        private string skinT = "Активировано";
        public static List<bool> skins = new List<bool>();
        List<bool> skins_truf = new List<bool>();
        public Shop() : base()
        {
            skins.Add(true);
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
            Width = 620;
            Height = 877;
            BackgroundImage = Resources.back;
            BackgroundImageLayout = ImageLayout.Stretch;
            shopP = new ShopP()
            {
                BackgroundImage = Resources.startmenu,
                BackgroundImageLayout = ImageLayout.Stretch
            };
            shopB = new MenuButton()
            {
                Width = 580,
                Height = 100,
                Location = new Point(10, 660),
                Text = skinT
            };
            Controls.Add(shopP);
            Controls.Add(shopB);
            shopB.Click += ShopB_Click;
            shopP.Click += ShopP_Click;
        }

        private void ShopB_Click(object sender, EventArgs e)
        {
            if (skins_truf[1] == false && skin == 1)
            {
                skins[1] = true;
                skins_truf[1] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
            }
            else if (skins_truf[1] == true && skin == 1)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[1] =  false;
            }
            if (skins_truf[2] == false && skin == 2)
            {
                skins[2] = true;
                skins_truf[2] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
            }
            else if (skins_truf[2] == true && skin == 2)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[2] = false;
            }
            if (skins_truf[3] == false && skin == 3)
            {
                skins[3] = true;
                skins_truf[3] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
            }
            else if (skins_truf[3] == true && skin == 3)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[3] = false;
            }
            if (skins_truf[4] == false && skin == 4)
            {
                skins[4] = true;
                skins_truf[4] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
            }
            else if (skins_truf[4] == true && skin == 4)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[4] = false;
            }
            if (skins_truf[5] == false && skin == 5)
            {
                skins[5] = true;
                skins_truf[5] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
            }
            else if (skins_truf[5] == true && skin == 5)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[5] = false;
            }
            if (skins_truf[6] == false && skin == 6)
            {
                skins[6] = true;
                skins_truf[6] = true;
                skinT = "Активировать";
                shopB.Text = skinT;
            }
            else if (skins_truf[6] == true && skin == 6)
            {
                skinT = "Активировано";
                shopB.Text = skinT;
                skins_truf[6] = false;
            }
        }

        private void ShopP_Click(object sender, EventArgs e)
        {
            if (skin != 7)
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
                    skinT = "купить:100b";
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
                    skinT = "купить:200b";
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
                    skinT = "купить:300b";
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
                    skinT = "купить:400b";
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
                    skinT = "купить:500b";
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
                    skinT = "купить:600b";
                    shopB.Text = skinT;
                }
                else
                {
                    skinT = "Активировать";
                    shopB.Text = skinT;
                }
            }
            //else if (skin == 7)
            //{
                //shopP.BackgroundImage = Resources.startmenuSM;
                //if (skins[7] == false)
                //{
                    //skinT = "купить:700b";
                    //shopB.Text = skinT;
                //}
                //else
                //{
                    //skinT = "Активировать";
                    //shopB.Text = skinT;
                //}
            //}
            else if (skin == 7)
            {
                skin = 0;
                shopP.BackgroundImage = Resources.startmenu;
                skinT = "Активировать";
                shopB.Text = skinT;
            }
        }
    }
}
