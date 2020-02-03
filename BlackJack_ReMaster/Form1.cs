using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_ReMaster
{
    public partial class Main : Form
    {
        Memory game = new Memory();
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_balance.Text = $"Balance: {game.Balance.ToString()}";
            panel_default.Visible = true;
            panel_play.Visible = false;
            panel_settings.Visible = false;

        }

        private void form_maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            bunifuElipse1.ElipseRadius = 0;
        }

        private void form_default_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            bunifuElipse1.ElipseRadius = 50;
        }

        private void menu_play_Click(object sender, EventArgs e)
        {
            panel_default.Visible = false;
            panel_play.Visible = true;
            panel_settings.Visible = false;

        }
        private void menu_settings_Click(object sender, EventArgs e)
        {
            panel_default.Visible = false;
            panel_play.Visible = false;
            panel_settings.Visible = true;

        }
        private void chip_Add_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32((sender as PictureBox).Tag);
            game.Balance -= amount;
            game.Pot += amount;
            label_pot.Text = $"Pot: {game.Pot.ToString()}";
            label_balance.Text = $"Balance: {game.Balance.ToString()}";
        }

        private void chips_toggle_Click(object sender, EventArgs e)
        {
            cmd_Done.Text = "DONE";
            if (game.Chip_Toggle == false)
            {
                cmd_Done.Visible = false;
                int x_of_100 = chip_100.Location.X + 70;
                int x_of_50 = chip_50.Location.X + 70 * 2;
                int x_of_15 = chip_15.Location.X + 70 * 3;
                int x_of_10 = chip_10.Location.X + 70 * 4;
                int x_of_5 = chip_5.Location.X + 70 * 5;
                chip_100.Visible = true;
                chip_50.Visible = true;
                chip_15.Visible = true;
                chip_10.Visible = true;
                chip_5.Visible = true;
                while (x_of_100 != chip_100.Location.X || x_of_50 != chip_50.Location.X || x_of_15 != chip_15.Location.X || x_of_10 != chip_10.Location.X || x_of_5 != chip_5.Location.X)
                {
                    if (chip_100.Location.X != x_of_100)
                        chip_100.Location = new Point(chip_100.Location.X + 5, chip_100.Location.Y);

                    if (chip_50.Location.X != x_of_50)
                        chip_50.Location = new Point(chip_50.Location.X + 5, chip_50.Location.Y);

                    if (chip_15.Location.X != x_of_15)
                        chip_15.Location = new Point(chip_15.Location.X + 5, chip_15.Location.Y);

                    if (chip_10.Location.X != x_of_10)
                        chip_10.Location = new Point(chip_10.Location.X + 5, chip_10.Location.Y);

                    if (chip_5.Location.X != x_of_5)
                        chip_5.Location = new Point(chip_5.Location.X + 5, chip_5.Location.Y);
                    this.Update();
                    Thread.Sleep(10);
                }
                chips_toggle.Update();
                game.Chip_Toggle = true;
            }
            else
            {

                int x_of_100 = chip_100.Location.X - 70;
                int x_of_50 = chip_50.Location.X - 70 * 2;
                int x_of_15 = chip_15.Location.X - 70 * 3;
                int x_of_10 = chip_10.Location.X - 70 * 4;
                int x_of_5 = chip_5.Location.X - 70 * 5;
                while (x_of_100 != chip_100.Location.X || x_of_50 != chip_50.Location.X || x_of_15 != chip_15.Location.X || x_of_10 != chip_10.Location.X || x_of_5 != chip_5.Location.X)
                {
                    if (chip_100.Location.X != x_of_100)
                        chip_100.Location = new Point(chip_100.Location.X - 5, chip_50.Location.Y);

                    if (chip_50.Location.X != x_of_50)
                        chip_50.Location = new Point(chip_50.Location.X - 5, chip_50.Location.Y);

                    if (chip_15.Location.X != x_of_15)
                        chip_15.Location = new Point(chip_15.Location.X - 5, chip_15.Location.Y);

                    if (chip_10.Location.X != x_of_10)
                        chip_10.Location = new Point(chip_10.Location.X - 5, chip_10.Location.Y);

                    if (chip_5.Location.X != x_of_5)
                        chip_5.Location = new Point(chip_5.Location.X - 5, chip_5.Location.Y);
                    this.Update();
                    Thread.Sleep(10);
                }

                chip_100.Visible = false;
                chip_50.Visible = false;
                chip_15.Visible = false;
                chip_10.Visible = false;
                chip_5.Visible = false;
                cmd_Done.Visible = true;
                chips_toggle.Update();
                game.Chip_Toggle = false;
            }
        }

        private void chip_reset_Click(object sender, EventArgs e)
        {
            game.Balance += game.Pot;
            game.Pot -= game.Pot;
            label_pot.Text = $"Pot: {game.Pot.ToString()}";
            label_balance.Text = $"Balance: {game.Balance.ToString()}";

        }






        private void cmd_Done_Click(object sender, EventArgs e)
        {
           card_d_aux.Location = new Point(avatar_dealer.Location.X, avatar_dealer.Location.Y+131);
            card_p_aux.Location = new Point(avatar_dealer.Location.X, card_d_aux.Location.Y+80);
            
            if (game.Surrender == false)
            {
            cmd_surrender.Enabled = true;
            game.Surrender = true;
            }

            if (game.Pot < 5)
            {
                cmd_Done.Text = "Pot must be >= 5";
                return;
            }
            panel_chips.Visible = false;
            cmd_double.Visible = true;
            cmd_hit.Visible = true;
            cmd_stand.Visible = true;
            cmd_surrender.Visible = true;

            game.Shuffle_deck();
            game.Begin_game();
            Render_Cards();
            game.IsGame = true;

            if (game.Player.Values.Sum() == 21)//auto win
            {
                cmd_double.Visible = false;
                cmd_hit.Visible = false;
                cmd_stand.Text = "BLACKJACK";
                cmd_surrender.Visible = false;
                game.Balance += game.Pot * 4;
                game.Pot = 0;
                Remove_Cards();
                game.IsGame = false;
                game.ShowOff = true;
                Render_Cards();

            }




        }
        private void Continue()
        {
            label_pot.Text = "Pot: 0";
            label_balance.Text = $"Balance: {game.Balance}";
            if (game.Pot > 0) return;
            panel_chips.Visible = true;
            cmd_double.Visible = false;
            cmd_hit.Visible = false;
            cmd_stand.Visible = false;
            cmd_surrender.Visible = false;
            return;
        }
        private void cmd_Hit()
        {
            game.Surrender = false;
            cmd_surrender.Enabled = false;
            if (cmd_hit.Text == "BUSTED")
            {
                game.Pot = 0;
                Remove_Cards();
                game.ShowOff = false;
                game.Deck.Clear();
                game.Player.Clear();
                game.Dealer.Clear();
                game.Shuffle_deck();
                player_pts.Text = "0";
                dealer_pts.Text = "0";
                this.Update();
                this.UpdateStyles();
                cmd_hit.Text = "HIT";
                Continue();
                return;
            }


            game.cmd_Hit();
            Remove_Cards();
            Render_Cards();




            if (game.Player.Values.Sum() > 21)
            {
                //Busted, end game
                game.IsGame = false;
                game.ShowOff = true;
                cmd_double.Visible = false;
                cmd_stand.Visible = false;
                cmd_surrender.Visible = false;
                cmd_hit.Text = "BUSTED";
                Remove_Cards();
                Render_Cards();
                return;
            }



            if (game.Player.Values.Sum() == 21) // blackjack
            {
                if (game.Dealer.Values.Sum() < 16)
                {
                    while (game.Dealer.Values.Sum() < 16)
                    {
                        game.cmd_Hit_Dealer();
                    }
                }

                if (game.Dealer.Values.Sum() == 21)
                {
                    Remove_Cards();
                    game.Balance += game.Pot;
                    game.IsGame = false;
                    game.ShowOff = true;
                    cmd_double.Visible = false;
                    cmd_surrender.Visible = false;
                    cmd_stand.Visible = false;
                    cmd_hit.Text = "TIE";
                    Render_Cards();
                    return;

                }
                else
                {
                    Remove_Cards();
                    game.Balance += game.Pot * 4;
                    game.IsGame = false;
                    game.ShowOff = true;
                    cmd_double.Visible = false;
                    cmd_surrender.Visible = false;
                    cmd_hit.Visible = false;
                    cmd_stand.Text = "BLACKJACK";
                    Render_Cards();
                    return;
                }





            }
            Render_Cards();


        }
        private void cmd_Stand()
        {

            if (cmd_stand.Text != "STAND")
            {
                game.Pot = 0;
                Remove_Cards();
                game.ShowOff = false;
                game.Deck.Clear();
                game.Player.Clear();
                game.Dealer.Clear();
                game.Shuffle_deck();
                player_pts.Text = "0";
                dealer_pts.Text = "0";
                this.Update();
                this.UpdateStyles();
                cmd_stand.Text = "STAND";
                Continue();
                return;
            }
            if (game.Dealer.Values.Sum() < 16)
            {
                while (game.Dealer.Values.Sum() < 16)
                {
                    game.cmd_Hit_Dealer();
                }
            }
            //  game.cmd_Hit()

            game.IsGame = false;
            game.ShowOff = true;
            Remove_Cards();
            Render_Cards();

            
            if (game.Dealer.Values.Sum() > game.Player.Values.Sum() && game.Dealer.Values.Sum() <= 21)
            {
                //Dealer have way more than player and might have blackjack dealer
                cmd_double.Visible = false;
                cmd_hit.Visible = false;
                cmd_surrender.Visible = false;
                cmd_stand.Text = "BUSTED";
                return;
            }

            if (game.Dealer.Values.Sum() == game.Player.Values.Sum())
            {
                //Dealer have way more than player
                game.Balance += game.Pot;
                cmd_double.Visible = false;
                cmd_surrender.Visible = false;
                cmd_hit.Visible = false;
                cmd_stand.Text = "TIE";
                return;
            }


            if (game.Dealer.Values.Sum() < game.Player.Values.Sum() || game.Dealer.Values.Sum() > 21)
            { //dealer delt cards yet lower than player
                if (game.Player.Values.Sum() == 21)
                    game.Balance += game.Pot * 4;
                else
                    game.Balance += game.Pot * 2;

                cmd_double.Visible = false;
                cmd_surrender.Visible = false;
                cmd_hit.Visible = false;
                cmd_stand.Text = "WIN";
                return;
            }
        }
        private void cmd_Surrender()
        {
            if (game.Surrender == false) return;
            game.Balance += game.Pot / 2;
            game.Pot = 0;
            Remove_Cards();
            Render_Cards();
            Continue();


        }
        private void cmd_Type_Click(object sender, EventArgs e)
        {
            string cmd = (sender as BunifuFlatButton).Tag.ToString();

            if(cmd == "stand")
                cmd_Stand();
            if (cmd == "hit")
                cmd_Hit();
            if (cmd == "surrender")
                cmd_Surrender();
        }
        private void Remove_Cards()
        {
            for (int x = 0; x < game.Dealer.Count() + game.Player.Count(); x++)
            {
                foreach (Control item in this.panel_play.Controls)
                {
                    if (item.Tag != null)
                    {
                        if (item.Tag.ToString() == "card")
                        {
                            this.panel_play.Controls.Remove(item);
                            item.Dispose();
                            continue;
                        }
                    }
                }
            }
        }
        public void Render_Cards()
        {
            
            int[] p1 = { card_p_aux.Location.X - 35, card_p_aux.Location.Y };
            int[] d1 = { card_d_aux.Location.X - 35, card_d_aux.Location.Y };
            foreach (KeyValuePair<string, int> a in game.Dealer)
            {
                var picture = new PictureBox
                {
                    Name = $"card_d_{a.Key}",
                    Size = new Size(64, 64),
                    Location = new Point(d1[0] + 70, d1[1]),
                    Image = (Image)Properties.Resources.ResourceManager.GetObject($"{a.Key}"),
                    Visible = true,
                    Anchor = AnchorStyles.None,
                    Tag = "card"
                };
                this.panel_play.Controls.Add(picture);
                //picture.BringToFront();
                d1[0] += 70;
                if (game.ShowOff == false)
                {
                    dealer_pts.Text = game.Dealer.Values.First().ToString();
                    var picture2 = new PictureBox
                    {
                        Name = $"card_d_hidden",
                        Size = new Size(64, 64),
                        Location = new Point(d1[0] + 70, d1[1]),
                        Image = (Image)Properties.Resources.ResourceManager.GetObject($"poker"),
                        Visible = true,
                        Anchor = AnchorStyles.None,
                        Tag = "card"
                    };
                    this.panel_play.Controls.Add(picture2);
                    d1[0] += 70;
                    break;
                }
                else if (game.ShowOff == true)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item.Name == "card_d_hidden")
                        {
                            this.panel_play.Controls.Remove(item);
                            break;
                        }
                    }


                }


            }
            foreach (KeyValuePair<string, int> a in game.Player)
            {
                var picture = new PictureBox
                {
                    Name = $"card_p_{a.Key}",
                    Size = new Size(64, 64),
                    Location = new Point(p1[0] + 70, p1[1]),
                    Image = (Image)Properties.Resources.ResourceManager.GetObject($"{a.Key}"),
                    Visible = true,
                    Anchor = AnchorStyles.None,
                    Tag = "card"
                };

                this.panel_play.Controls.Add(picture);
                picture.BringToFront();
                p1[0] += 70;
            }


            if (game.ShowOff == true) dealer_pts.Text = game.Dealer.Values.Sum().ToString();
            player_pts.Text = game.Player.Values.Sum().ToString();
            panel_play.Update();
            this.UpdateStyles();

        }
    }
}
