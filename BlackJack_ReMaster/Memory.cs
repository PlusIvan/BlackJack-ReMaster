using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_ReMaster
{
    class Memory
    {
        private static Dictionary<string, int> deck = new Dictionary<string, int>();
        private static string[] cards = { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        private static string[] suits = { "s", "c", "d", "h" };
        private static Random rand = new Random();
        private static Dictionary<string, int> player = new Dictionary<string, int>();
        private static Dictionary<string, int> dealer = new Dictionary<string, int>();
        private static Boolean isgame = false;
        private static int decks = 1;
        private static Boolean isjoker = false;
        private static Boolean isroyals = false;
        private static int balance = 10000;
        private static Boolean show_off = false;
        private static int pot = 0;
        private static Boolean chip_toggle = false;
        private static Boolean surrender = true;
        public Boolean Surrender
        {
            get { return surrender; }
            set { surrender = value; }
        }
        public Boolean Chip_Toggle
        {
            get { return chip_toggle; }
            set { chip_toggle = value; }
        }
        public int Pot
        {
            get { return pot; }
            set { pot = value; }
        }
        public Boolean ShowOff
        {
            get { return show_off; }
            set { show_off = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int Decks
        {
            get { return decks; }
            set { decks = value; }
        }

        public Boolean IsRoyals
        {
            get { return isroyals; }
            set { isroyals = value; }
        }
        public Boolean IsJoker
        {
            get { return isjoker; }
            set { isjoker = value; }
        }

        public Boolean IsGame
        {
            get { return isgame; }
            set { isgame = value; }
        }
        public Dictionary<string, int> Deck
        {
            get { return deck; }
            set { deck = value; }
        }
        public Dictionary<string, int> Player
        {
            get { return player; }
            set { player = value; }
        }
        public Dictionary<string, int> Dealer
        {
            get { return dealer; }
            set { dealer = value; }
        }
        public void Shuffle_deck()
        {
            deck.Clear();

            foreach (string card in cards)
            {
                foreach (string suit in suits)
                {
                    int value = 0;
                    if (card == "A")
                        value = 11;
                    else if (card == "K" || card == "Q" || card == "J")
                        value = 10;
                    else
                        value = Convert.ToInt32(card);
                    deck.Add(card + suit, value);
                }
            }
            List<string> keyList = new List<string>(deck.Keys);
            Dictionary<string, int> deck_aux = new Dictionary<string, int>();

            while (deck.Count > 0)
            {
                string randomKey = keyList[rand.Next(keyList.Count)];
                deck_aux.Add(randomKey, deck[randomKey]);
                deck.Remove(randomKey);
                keyList.Remove(randomKey);
            }
            deck = deck_aux;
        }


        public void Begin_game()
        {
            if (IsGame == true) return;


            List<string> keyList = new List<string>(deck.Keys);
            while (player.Count != 2)
            {
                string randomKey = keyList[rand.Next(keyList.Count)];
                player.Add(randomKey, deck[randomKey]);
                deck.Remove(randomKey);
                keyList.Remove(randomKey);
            }
            while (dealer.Count != 2)
            {
                string randomKey = keyList[rand.Next(keyList.Count)];
                dealer.Add(randomKey, deck[randomKey]);
                deck.Remove(randomKey);
                keyList.Remove(randomKey);
            }




            IsGame = true;
        }

        public void cmd_Hit()
        {
            List<string> keyList = new List<string>(deck.Keys);
            string randomKey = keyList[rand.Next(keyList.Count)];
            player.Add(randomKey, deck[randomKey]);
            deck.Remove(randomKey);
            keyList.Remove(randomKey);
            if (player.ContainsValue(11) && player.Values.Sum() > 21)//over 21, look up for aces with 11
                player[player.Where(pair => pair.Value == 11).Select(pair => pair.Key).FirstOrDefault()] = 1;
        }
        public void cmd_Hit_Dealer()
        {
            List<string> keyList = new List<string>(deck.Keys);
            string randomKey = keyList[rand.Next(keyList.Count)];
            dealer.Add(randomKey, deck[randomKey]);
            deck.Remove(randomKey);
            keyList.Remove(randomKey);
            if (dealer.ContainsValue(11) && dealer.Values.Sum() > 21)//over 21, look up for aces with 11
                dealer[dealer.Where(pair => pair.Value == 11).Select(pair => pair.Key).FirstOrDefault()] = 1;
        }
    }
}
