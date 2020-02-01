using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Solo_game
    {
        private static Dictionary<string, int> deck = new Dictionary<string, int>();
        public string[] cards = { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        public string[] suits = { "s", "c", "d", "h" };
        public Random rand = new Random();
        public Dictionary<string, int> player = new Dictionary<string, int>();
        public Dictionary<string, int> dealer = new Dictionary<string, int>();
        private static Boolean isgame = false;

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
        public void Shuffle_deck()
        {
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




        }




    }
}
