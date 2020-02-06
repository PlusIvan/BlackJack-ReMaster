using Bunifu.Framework.UI;
using Microsoft.WindowsAPICodePack.Dialogs;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
namespace BlackJack_ReMaster
{
    public partial class Main : Form
    {






        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        Memory game = new Memory();
        Soundtrack soundtrack = new Soundtrack();
        Logic logic = new Logic();
        


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
        private void Main_Shown(object sender, EventArgs e)
        {
            /*  int def_pos_play = menu_play.Location.Y;
              int def_pos_multi = menu_multiplayer.Location.Y;
              int def_pos_sett = menu_settings.Location.Y;

              menu_play.Location = new Point(logo_game.Location.X, logo_game.Location.Y);
              menu_multiplayer.Location = new Point(logo_game.Location.X, logo_game.Location.Y);
              menu_settings.Location = new Point(logo_game.Location.X, logo_game.Location.Y);
              menu_play.Visible = true;
              menu_multiplayer.Visible = true;
              menu_settings.Visible = true;

              while (def_pos_play != menu_play.Location.Y || def_pos_multi != menu_multiplayer.Location.Y || def_pos_sett != menu_settings.Location.Y)
              {
                  if (menu_play.Location.Y != def_pos_play)
                      menu_play.Location = new Point(menu_play.Location.X, menu_play.Location.Y + 1);

                  if (menu_multiplayer.Location.Y != def_pos_multi)
                      menu_multiplayer.Location = new Point(menu_multiplayer.Location.X, menu_multiplayer.Location.Y + 1);

                  if (menu_settings.Location.Y != def_pos_sett)
                      menu_settings.Location = new Point(menu_settings.Location.X, menu_settings.Location.Y + 1);
                  this.Update();
                  Thread.Sleep(1);
              }
              */
            menu_play.Visible = true;
            menu_multiplayer.Visible = true;
            menu_settings.Visible = true;
        }

        Boolean server_status_ = false;
        Websocks ws = new Websocks();
        private void connect_server_Click(object sender, EventArgs e)
        {
            if (websocket_username.Text.Length < 6 || websocket_ip.Text.Length < 7)
            {
                MessageBox.Show("Fix params");
                return;
            }

            if (ws.isConnected == false)
            {
                ws.Establish_Connection();
            }
            else
            {
                ws.SendEvent();
            }

           // string cmd = (sender as BunifuFlatButton).Tag.ToString();

               // var socket = IO.Socket($"http://{websocket_ip.Text}:3000");




            /*WebSocket*/
            /*
            string username_public = $"{websocket_username.Text}";
            socket.On(Socket.EVENT_CONNECT, () =>
            {
                socket.Emit("ping");
                server_status_ = true;
            });
            socket.On("ping", (data) =>
            {
                //Console.WriteLine(data);
                // socket.Disconnect();
                server_status.Text = "Connected";
            });
            socket.Emit("join");
            Console.ReadLine();

            */


        }

        private void WebSocket()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label_balance.Text = $"Balance: {game.Balance.ToString()}";
            panel_default.Visible = true;
            panel_play.Visible = false;
            panel_settings.Visible = false;

            panel_multiplayer.Visible = false;





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
            panel_multiplayer.Visible = false;

        }
        private void menu_settings_Click(object sender, EventArgs e)
        {
            panel_default.Visible = false;
            panel_play.Visible = false;
            panel_settings.Visible = true;
            panel_multiplayer.Visible = false;
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
            //  card_d_aux.Location = new Point(avatar_dealer.Location.X, avatar_dealer.Location.Y+131);
            //  card_p_aux.Location = new Point(avatar_dealer.Location.X, card_d_aux.Location.Y+80);
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
            logic.Prize = game.Pot;
       /*     if (game.Player.Values.Sum() == 21)//auto win
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
            */



        }
        private void Continue()
        {
            label_pot.Text = "Pot: 0";
            label_balance.Text = $"Balance: {game.Balance}";
            logic.Player_Pts = 0;
            logic.Dealer_Pts = 0;
            logic.Prize = 0;
            logic.isBJ_Dlayer = false;
            logic.isBJ_Player = false;
            logic.isPlayer_Busted = false;
            logic.isDealer_Busted = false;
            logic.Status = "";
            game.Dealer.Clear();
            game.Player.Clear();
            game.Pot = 0;
            //if (game.Pot > 0) return;
            panel_chips.Visible = true;
            cmd_double.Visible = false;
            cmd_hit.Visible = false;
            cmd_stand.Visible = false;
            cmd_surrender.Visible = false;
            cmd_double.Enabled = true;
            cmd_surrender.Enabled = true;
            game.ShowOff = false;
            Remove_Cards();
            this.Update();
            return;
        }
        private void cmd_Hit()
        {
            Console.WriteLine("func invoke");
            if (cmd_hit.Text.ToLower() != "hit")
            {
                Console.WriteLine("re start");
                Remove_Cards();
                Continue();
                cmd_hit.Text = "hit".ToUpper();
                return;
            }
            Console.WriteLine("after");
            cmd_double.Enabled = false;
            cmd_surrender.Enabled = false;
            game.cmd_Hit();

            logic.Player_Pts = game.Player.Values.Sum();
            logic.Dealer_Pts = game.Dealer.Values.Sum();
           // logic.Prize = game.Pot;
            if(logic.Can_Player_Continue() == false)
            {


               // game.cmd_Hit_Dealer();
                game.ShowOff = true;
                logic.Player_Pts = game.Player.Values.Sum();
                logic.Dealer_Pts = game.Dealer.Values.Sum();
                logic.Prize = game.Pot;
                logic.WhoWin();
                Remove_Cards();
                Render_Cards();
                //possible status, "win", "tie", "lost"
                game.Balance += logic.Prize;
                cmd_hit.Text = $"You {logic.Status} ${logic.Prize}";
                cmd_stand.Visible = false;
                cmd_double.Visible = false;
                cmd_surrender.Visible = false;

                return;
            }


            Remove_Cards();
            Render_Cards();




        }
        private void cmd_Stand()
        {
            if (cmd_stand.Text.ToLower() != "stand")
            {
                Remove_Cards();
                Continue();
                cmd_stand.Text = "stand".ToUpper();
                return;
            }
          //  game.cmd_Hit_Dealer();
            game.ShowOff = true;
            logic.Player_Pts = game.Player.Values.Sum();
            logic.Dealer_Pts = game.Dealer.Values.Sum();
            logic.Prize = game.Pot;
            logic.WhoWin();
            Remove_Cards();
            Render_Cards();
            //possible status, "win", "tie", "lost"
            game.Balance += logic.Prize;
            cmd_stand.Text = $"You {logic.Status} ${logic.Prize}";
            cmd_hit.Visible = false;
            cmd_double.Visible = false;
            cmd_surrender.Visible = false;
        }
        private void cmd_Surrender()
        {
            if (cmd_surrender.Text.ToLower() != "surrender")
            {
                Remove_Cards();
                Continue();
                cmd_surrender.Text = "surrender".ToUpper();
                return;
            }
            game.ShowOff = true;
            Remove_Cards();
            Render_Cards();
            //possible status, "win", "tie", "lost"
            game.Balance += game.Pot/2;
            cmd_surrender.Text = $"Return ${game.Pot/2}";
            cmd_hit.Visible = false;
            cmd_double.Visible = false;
            cmd_stand.Visible = false;
        }
        
        private void cmd_Double()
        {

            if (cmd_double.Text.ToLower() != "double")
            {
                Remove_Cards();
                Continue();
                cmd_double.Text = "double".ToUpper();
                return;
            }

            if (game.Pot*2 > game.Balance) { return; }
            game.cmd_Hit();
           // game.cmd_Hit_Dealer();
            game.Pot += game.Pot*2;
            game.Balance -= game.Pot*2;

            game.ShowOff = true;
            logic.Player_Pts = game.Player.Values.Sum();
            logic.Dealer_Pts = game.Dealer.Values.Sum();
            logic.Prize = game.Pot;
            logic.WhoWin();
            Remove_Cards();
            Render_Cards();
            //possible status, "win", "tie", "lost"
            game.Balance += logic.Prize;
            cmd_double.Text = $"You {logic.Status} ${logic.Prize}";
            cmd_hit.Visible = false;
            cmd_stand.Visible = false;
            cmd_surrender.Visible = false;




        }
        private void cmd_Type_Click(object sender, EventArgs e)
        {
            string cmd = (sender as BunifuFlatButton).Tag.ToString();

            if (cmd == "stand")
                cmd_Stand();
            if (cmd == "hit")
                cmd_Hit();
            if (cmd == "surrender")
                cmd_Surrender();
            if (cmd == "double")
                cmd_Double();
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
            dealer_pts.Text = "0".ToLower().ToString();
            player_pts.Text = "0".ToLower().ToString();
            this.UpdateStyles();
            this.Update();
        }
        public void Render_Cards()
        {

            int[] p1 = { card_p_aux.Location.X - 70, card_p_aux.Location.Y };
            int[] d1 = { card_d_aux.Location.X - 70, card_d_aux.Location.Y };
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
            this.Update();
        }

        private void load_tracksound_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                input_soundtrack.Text = dialog.FileName;
            soundtrack.SoundTrack_Path = input_soundtrack.Text;

            string[] list = Directory.GetFiles(input_soundtrack.Text, "*.mp3");
            combo_musics.Items.Clear();
            foreach (string l in list)
                combo_musics.Items.Add(Path.GetFileName(l));


        }
        private void cmd_Type_Music(object sender, EventArgs e)
        {
            if(soundtrack.SoundTrack_Path == "" || soundtrack.SoundTrack_FileName == "")
            {
                MessageBox.Show("no");
                return;
            }
            string cmd = (sender as BunifuFlatButton).Tag.ToString();

            if (cmd == "play")
                soundtrack.Play();
            if (cmd == "pause")
                soundtrack.Pause();
            if (cmd == "previous")
                soundtrack.Previous();
            if (cmd == "next")
                soundtrack.Next();
            if (cmd == "stop")
                soundtrack.Reset();
        }

        private void form_min_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void form_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_musics_TextUpdate(object sender, EventArgs e)
        {
            soundtrack.SoundTrack_FileName = combo_musics.SelectedItem.ToString();
        }

        private void menu_multiplayer_Click(object sender, EventArgs e)
        {
            panel_default.Visible = false;
            panel_play.Visible = false;
            panel_settings.Visible = false;
            panel_multiplayer.Visible = true;
        }

        private void server_status_TextChanged(object sender, EventArgs e)
        {
            if (server_status.Text.ToLower() == "connected")
            {
                server_joingame.Visible = true;
                server_joingame.Enabled = false;
                server_status.Text = "...Waiting for server authorization...";
            }
            else
            {
                return;
            }

        }
    }
}
