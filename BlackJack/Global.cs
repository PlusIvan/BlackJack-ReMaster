using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace BlackJack
{
    class Global
    {
        public dynamic core = JObject.Parse(@"{
settings:{joker:false},
main:{menu_solo:[0,0],menu_multiplayer:[0,0],menu_settings:[0,0]},
multiplayer:{},
solo:{balance:{wallet:0,balance:0,btn_enabled:false},game:{pot:0}}
}");
        public dynamic path_music = "";
        public Boolean musicEnabled = false;



    }
}
