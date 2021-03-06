﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Net;
namespace BlackJack
{
    public partial class Menu : Form
    {
        bool drag = true;
        Point start_point = new Point(0,0);
        Animate animate = new Animate();
        //public Solo_game game = new Solo_game();
        public Menu()
        {
            InitializeComponent();

        }
        private void animator_one_Tick(object sender, EventArgs e)
        {
            
            menu_solo.Location = new Point(menu_solo.Location.X-350, menu_solo.Location.Y-350);
            menu_multiplayer.Location = new Point(menu_multiplayer.Location.X+ 350, menu_multiplayer.Location.Y+350);
            menu_settings.Location = new Point(menu_settings.Location.X- 350, menu_settings.Location.Y-350);
            //JArray Contains X,Y where it suppoused to be
            menu_solo.Visible = true;
            while (animate.MenuSolo[0] != menu_solo.Location.X)
            {
                menu_solo.Location = new Point(menu_solo.Location.X + 1, menu_solo.Location.Y+1);
                menu_solo.Update();
            }

            menu_multiplayer.Visible = true;
            while (animate.MenuMultiplayer[0] != menu_multiplayer.Location.X)
            {
                menu_multiplayer.Location = new Point(menu_multiplayer.Location.X - 1, menu_multiplayer.Location.Y-1);
                menu_multiplayer.Update();
            }

            menu_settings.Visible = true;
            while (animate.MenuSettings[0] != menu_settings.Location.X)
            {
                menu_settings.Location = new Point(menu_settings.Location.X + 1, menu_settings.Location.Y+1);
                menu_settings.Update();
            }
           
            animator_one.Stop();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            animate.MenuSolo[0] = menu_solo.Location.X;
            animate.MenuSolo[1] = menu_solo.Location.Y;
            animate.MenuMultiplayer[0] = menu_multiplayer.Location.X;
            animate.MenuMultiplayer[1] = menu_multiplayer.Location.Y;
            animate.MenuSettings[0] = menu_settings.Location.X;
            animate.MenuSettings[1] = menu_settings.Location.Y;
            /*  

              // MessageBox.Show(array[0].ToString()) ;
              // MessageBox.Show(array[1].ToString());
              // th = new Thread(Threads);
              // th1 = new Thread(Threads2);
              this.Update();


           
              //  animator_one.Start();
            
              Thread oThreadone = new Thread(Work1);
              Thread oThreadtwo = new Thread(Work2);
              oThreadone.Start();
              oThreadtwo.Start();
  */
            //backgroundWorker1.RunWorkerAsync();
            //backgroundWorker1.DoWork();

            //pictureBox1.Image = BlackJack.Properties.Resources.jkjijk
            //  label1.Parent = pictureBox1;
            //   label1.BackColor = Color.Transparent;
        }
        public void Work2()
        {
            Invoke(new Action(() =>
            {
               
                    string dump = "BLACKJACK";
                    logo_cards.Visible = true;
                    label_title_game.Visible = true;
                    logo_cards.Update();
                    while (dump != "")
                    {
                        label_title_game.Text += dump[0];
                        dump = dump.Remove(0, 1);
                        label_title_game.Update();
                        Thread.Sleep(150);
                    }
                    logo_heart.Visible = true;
                    label_title_game.SendToBack();
                    Thread.Sleep(100);
            }));
            
        }
        public void Work1()
        {
            Invoke(new Action(() =>
            {

                menu_solo.Location = new Point(menu_solo.Location.X - 350, menu_solo.Location.Y - 350);
                menu_multiplayer.Location = new Point(menu_multiplayer.Location.X + 350, menu_multiplayer.Location.Y + 350);
                menu_settings.Location = new Point(menu_settings.Location.X - 350, menu_settings.Location.Y - 350);
                //JArray Contains X,Y where it suppoused to be
                menu_solo.Visible = true;
                while (animate.MenuSolo[0] != menu_solo.Location.X)
                {
                    menu_solo.Location = new Point(menu_solo.Location.X + 1, menu_solo.Location.Y + 1);
                    menu_solo.Update();
                }

                menu_multiplayer.Visible = true;
                while (animate.MenuMultiplayer[0] != menu_multiplayer.Location.X)
                {
                    menu_multiplayer.Location = new Point(menu_multiplayer.Location.X - 1, menu_multiplayer.Location.Y - 1);
                    menu_multiplayer.Update();
                }

                menu_settings.Visible = true;
                while (animate.MenuSettings[0] != menu_settings.Location.X)
                {
                    menu_settings.Location = new Point(menu_settings.Location.X + 1, menu_settings.Location.Y + 1);
                    menu_settings.Update();
                }


            }));

            
        }
        private void menu_settings_Click(object sender, EventArgs e)
        {
            forms.Settings form = new forms.Settings();
            form.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void metroSetPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void metroSetPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X-start_point.X,p.Y-start_point.Y);
            }
                
        }
        private void metroSetPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void menu_multiplayer_Click(object sender, EventArgs e)
        {
            forms.Multiplayer form = new forms.Multiplayer();
            form.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void menu_solo_Click(object sender, EventArgs e)
        {
            forms.Solo form = new forms.Solo();
            form.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                BackgroundWorker worker = sender as BackgroundWorker;





                for (int i = 1; i <= 10; i++)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(500);
                        worker.ReportProgress(i * 10);
                    }
                }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           // resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
        }
    }
}
