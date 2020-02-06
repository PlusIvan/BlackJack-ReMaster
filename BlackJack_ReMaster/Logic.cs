using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_ReMaster
{
    class Logic
    {
        private static int player_pts = 0;
        private static int dealer_pts = 0;
        private static Boolean isbj_player = false;
        private static Boolean isbj_dealer = false;
        private static Boolean isdealer_busted = false;
        private static Boolean isplayer_busted = false;
        private static int prize = 0;
        private static int multiply = 1; //default win *1, blackjack *4, joker*8
        private static string status = "";
        // public Main main = new Main(); why you no work
        public Memory game = new Memory();
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public int Player_Pts
        {
            get { return player_pts; }
            set { player_pts = value; }
        }
        public int Dealer_Pts
        {
            get { return dealer_pts; }
            set { dealer_pts = value; }
        }

        public int Multiply
        {
            get { return multiply; }
            set { multiply = value; }
        }
        public int Prize
        {
            get { return prize; }
            set { prize = value; }
        }
        public Boolean isBJ_Dlayer
        {
            get { return isbj_dealer; }
            set { isbj_dealer = value; }
        }

        public Boolean isBJ_Player
        {
            get { return isbj_player; }
            set { isbj_player = value; }
        }
        public Boolean isDealer_Busted
        {
            get { return isdealer_busted; }
            set { isdealer_busted = value; }
        }
        public Boolean isPlayer_Busted
        {
            get { return isplayer_busted; }
            set { isplayer_busted = value; }
        }
        public Boolean Can_Player_Continue()
        {
            if (Player_Pts <= 21)
                return true;
            else
                return false;
            
        }

        public void WhoWin()
        {

            if (Player_Pts > 21) { //if player  21
                isPlayer_Busted = true;
                Status = "lost";
                Multiply = 0;
                Prize *= multiply;
                return;
            }



            //the final boss
            if (Dealer_Pts < 16 && isPlayer_Busted == false)
            {
                Console.WriteLine("Dealred less 16");
                while (Dealer_Pts < 16)
                {
                    Console.WriteLine("Dealer pts: " + game.Dealer.Values.Sum());
                    game.cmd_Hit_Dealer();

                    Dealer_Pts = game.Dealer.Values.Sum();
                    Console.WriteLine("Dealer pts after: " + game.Dealer.Values.Sum());
                }

            }





            if (Dealer_Pts > 21) //if dealer > 21
                isDealer_Busted = true;
            





            if (Dealer_Pts > Player_Pts && isDealer_Busted != true)
            {
                isPlayer_Busted = true;
                Status = "lost";
                Multiply = 0;
                Prize *= multiply;
                return;
            }

            if (Dealer_Pts == Player_Pts && isDealer_Busted != true)
            {
                Status = "tie";
                Multiply = 1;
                Prize *= multiply;
                return;
            }
            if (Dealer_Pts < Player_Pts || isDealer_Busted == true)
            {
                Status = "win";
                Multiply = 2;
            }

            if (Player_Pts == 21)
            {
                isBJ_Player = true;
                Multiply = 4;
            }
            //logic passed, multiply prize
            Prize *= multiply;





        }
    }
}
