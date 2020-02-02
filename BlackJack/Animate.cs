using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Animate
    {
        private static int[] btn_MenuSolo = { 0,0 };
        private static int[] btn_MenuMultiplayer = { 0,0 };
        private static int[] btn_MenuSettings = { 0,0 };


        public int[] MenuSolo
        {
            get { return btn_MenuSolo; }
            set { btn_MenuSolo = value; }
        }
        public int[] MenuMultiplayer
        {
            get { return btn_MenuMultiplayer; }
            set { btn_MenuMultiplayer = value; }
        }
        public int[] MenuSettings
        {
            get { return btn_MenuSettings; }
            set { btn_MenuSettings = value; }
        }

    }
}
