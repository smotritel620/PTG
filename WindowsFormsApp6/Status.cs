using System;
using System.Collections.Generic;

namespace WindowsFormsApp6
{
    [Serializable]
    class Status
    {
        bool[] skins2;
        int ball2;
        public Status()
        {
            skins2 = Shop.skins.ToArray();
            ball2 = Form1.ball;
        }

        public void Load()
        {
            Shop.skins = new List<bool>(skins2);
            Form1.ball = ball2;
        }
    }
}
