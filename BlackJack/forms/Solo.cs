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

namespace BlackJack.forms
{
    public partial class Solo : Form
    {
        
        bool drag = true;
        Point start_point = new Point(0, 0);

        Solo_game game =  new Solo_game();
        
        public Solo()
        {
            InitializeComponent();
        }

        private void metroSetPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            
            drag = false;
        }

        private void metroSetPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void metroSetPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void Solo_Load(object sender, EventArgs e)
        {
            //animate_chips.Start();
           // MessageBox.Show();
           // label_balance.Text = global.core.solo.balance.balance;

            if(game.IsGame == false)
            {
                solo_title.Visible = true;
                solo_begin.Visible = true;
            }
            else
            {
                solo_title.Visible = false;
                solo_begin.Visible = false;
                balance_icon.Visible = true;
                label_balance.Visible = true;
                dealer_pts.Visible = true;
                player_pts.Visible = true;
            }
        }

        private void chip_MouseHover(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BorderStyle = BorderStyle.FixedSingle;
            Cursor.Current = Cursors.Hand;
        }
        private void chip_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BorderStyle = BorderStyle.None;
            Cursor.Current = Cursors.Default;
        }

        private void animate_chips_Tick(object sender, EventArgs e)
        {
            //diff x: 




        }

        private void chip_plus_Click(object sender, EventArgs e)
        {

            if (chip_plus.BorderStyle.ToString() != "FixedSingle") return;
            cmd_Done.Visible = false;
            int x_of_100 = chip_100.Location.X + 70;
            int x_of_50 = chip_50.Location.X + 70 *2;
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
              this.Update();   Thread.Sleep(5);
               
            }


            chip_plus.BorderStyle = BorderStyle.None;
            chip_minus.BorderStyle = BorderStyle.FixedSingle;
            chip_plus.Update();
            chip_minus.Update();
        }

        private void chip_minus_Click(object sender, EventArgs e)
        {
            if (chip_minus.BorderStyle.ToString() != "FixedSingle") return;

            
            int x_of_100 = chip_100.Location.X - 70;
            int x_of_50 = chip_50.Location.X - 70*2;
            int x_of_15 = chip_15.Location.X - 70 * 3;
            int x_of_10 = chip_10.Location.X - 70 * 4;
            int x_of_5 = chip_5.Location.X - 70 * 5;
            while (x_of_100 != chip_100.Location.X ||  x_of_50 != chip_50.Location.X || x_of_15 != chip_15.Location.X || x_of_10 != chip_10.Location.X || x_of_5 != chip_5.Location.X)
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
                Thread.Sleep(5);
                
            }

            chip_100.Visible = false;
            chip_50.Visible = false;
            chip_15.Visible = false;
            chip_10.Visible = false;
            chip_5.Visible = false;
            

            chip_plus.BorderStyle = BorderStyle.FixedSingle;
            chip_minus.BorderStyle = BorderStyle.None;
            chip_plus.Update();
            chip_minus.Update();
            cmd_Done.Visible = true;
        }

        private void balance_icon_Click(object sender, EventArgs e)
        {
            //balance_plus, balance_minus
            if (balance_plus.Visible == false || balance_minus.Visible == false)
            {
                balance_plus.Location = new Point(balance_icon.Location.X, balance_icon.Location.Y);
                balance_minus.Location = new Point(balance_icon.Location.X, balance_icon.Location.Y);
                balance_plus.Visible = true;
                balance_minus.Visible = true;
                for(int x= 0; x < 70; x++)
                {
                    balance_plus.Location = new Point(balance_plus.Location.X, balance_plus.Location.Y-1);
                    balance_minus.Location = new Point(balance_minus.Location.X, balance_minus.Location.Y-2);
                    balance_plus.Update();
                    balance_minus.Update();
                    balance_icon.Update();
                    Thread.Sleep(1);
                }

            }
            else
            {
                for (int x = 0; x < 70; x++)
                {
                    balance_plus.Location = new Point(balance_plus.Location.X, balance_plus.Location.Y + 1);
                    balance_minus.Location = new Point(balance_minus.Location.X, balance_minus.Location.Y + 2);
                    balance_plus.Update();
                    balance_minus.Update();
                    balance_icon.Update();
                    Thread.Sleep(1);
                }
                balance_plus.Visible = false;
                balance_minus.Visible = false;
            }
        }

        private void balance_plus_Click(object sender, EventArgs e)
        {

        }

        private void balance_minus_Click(object sender, EventArgs e)
        {

        }

        private void solo_begin_Click(object sender, EventArgs e)
        {
            if (game.IsGame == true) return;

            solo_title.Visible = false;
            solo_begin.Visible = false;
            balance_icon.Visible = true;
            label_balance.Visible = true;
            dealer_pts.Visible = true;
            player_pts.Visible = true;
            game.Shuffle_deck();
            game.Begin_game();
            Render_Cards();
game.IsGame = true;
            pot_size.Visible = true;

            if(game.Pot == 0)
            {
                panel_chips.Visible = true;
                cmd_Double.Visible = false;
                cmd_Hit.Visible = false;
                cmd_Stand.Visible = false;
                cmd_Surrender.Visible = false;
            }

        }

        private void Render_Cards()
        {
            int[] p1 = { card_l_player.Location.X-35, card_l_player.Location.Y };
            int[] d1 = { card_l_dealer.Location.X-35, card_l_dealer.Location.Y };
            card_l_dealer.Visible = false;
            card_l_player.Visible = false;
            p1[0] -= 35;
            d1[0] -= 35;
            foreach (KeyValuePair<string,int> a in game.Dealer)
            {
                var picture = new PictureBox
                {
                    Name = $"card_d_{a.Key}",
                    Size = new Size(64, 64),
                    Location = new Point(d1[0]+70, d1[1]),
                    Image = (Image)Properties.Resources.ResourceManager.GetObject($"{a.Key}"),
                    Visible = true,
                    Anchor = AnchorStyles.None
                };
                dealer_pts.BadgeText = Convert.ToInt16(a.Value+ Convert.ToInt16(dealer_pts.BadgeText)).ToString();
                this.Controls.Add(picture);
                //picture.BringToFront();
                d1[0] += 70;
                picture.Update();
                if (game.ShowOff == false) {
                    var picture2 = new PictureBox
                    {
                        Name = $"card_d_hidden",
                        Size = new Size(64, 64),
                        Location = new Point(d1[0] + 70, d1[1]),
                        Image = (Image)Properties.Resources.ResourceManager.GetObject($"poker"),
                        Visible = true,
                        Anchor = AnchorStyles.None
                    };
                    this.Controls.Add(picture2);
                    d1[0] += 70;
                    picture.Update();
                    break;
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
                    Anchor = AnchorStyles.None
                };
                player_pts.BadgeText = Convert.ToInt16(a.Value + Convert.ToInt16(player_pts.BadgeText)).ToString();
                this.Controls.Add(picture);
                //picture.BringToFront();
                p1[0] += 70;
                picture.Update();
            }

        }

        private void Warn_NoBal()
        {

        }

        private void chip_5_Click(object sender, EventArgs e)
        {

            game.Balance -= 5;
            game.Pot += 5;
            label_balance.Text = $"Balance: {game.Balance.ToString()}";
        }

        private void chip_10_Click(object sender, EventArgs e)
        {
            game.Balance -= 10;
            game.Pot += 10;
            label_balance.Text = $"Balance: {game.Balance.ToString()}";
        }

        private void chip_15_Click(object sender, EventArgs e)
        {
            game.Balance -= 15;
            game.Pot += 15;
            label_balance.Text = $"Balance: {game.Balance.ToString()}";
        }

        private void chip_50_Click(object sender, EventArgs e)
        {
            game.Balance -= 50;
            game.Pot += 50;
            label_balance.Text = $"Balance: {game.Balance.ToString()}";
        }

        private void chip_100_Click(object sender, EventArgs e)
        {
            game.Balance -= 100;
            game.Pot += 100;
            label_balance.Text = $"Balance: {game.Balance.ToString()}";
        }

        private void label_balance_TextChanged(object sender, EventArgs e)
        {
            pot_size.Text = game.Pot.ToString();
        }

        private void cmd_Done_Click(object sender, EventArgs e)
        {
            if (game.Pot == 0) {
                MessageBox.Show("You must add to pot");
                return;
            }
            panel_chips.Visible = false;
            cmd_Double.Visible = true;
            cmd_Hit.Visible = true;
            cmd_Stand.Visible = true;
            cmd_Surrender.Visible = true;

        }
    }
}
