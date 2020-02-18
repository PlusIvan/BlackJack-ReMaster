using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_ReMaster
{
    class Websocks
    {
        private static string server_ip = "";
        private static string server_port = "";
        private static int player_balance = 1000;
        private static int players_card_pts = 0;
        private static string player_username = "";
        private static string player_chat_message = "";
        private static string player_command = "under";
        private static string game_status = "";
        private static Boolean player_registered = false;
        private static Dictionary<string, int> player_cards = new Dictionary<string, int>();
        private static Dictionary<string, int> dealer_cards = new Dictionary<string, int>();

        public Boolean PlayerRegistered
        {
            get { return player_registered; }
            set { player_registered = value; }
        }
        public string GameStatus
        {
            get { return game_status; }
            set { game_status = value; }
        }
        public Dictionary<string, int> PlayerCards
        {
            get { return player_cards; }
            set { player_cards = value; }
        }
        public Dictionary<string, int> DealerCards
        {
            get { return dealer_cards; }
            set { dealer_cards = value; }
        }
        public string PlayerCommand
        {
            get { return player_command; }
            set { player_command = value; }
        }

        public string PlayerChatMessage
        {
            get { return player_chat_message; }
            set { player_chat_message = value; }
        }
        public int PlayerPoints
        {
            get { return players_card_pts; }
            set { players_card_pts = value; }
        }
        public int PlayerBalance
        {
            get { return player_balance; }
            set { player_balance = value; }
        }

        public string PlayerUsername
        {
            get { return player_username; }
            set { player_username = value; }
        }

        public string ServerPort
        {
            get { return server_port; }
            set { server_port = value; }
        }
        public string ServerIP
        {
            get { return server_ip; }
            set { server_ip = value; }
        }

    }
}
