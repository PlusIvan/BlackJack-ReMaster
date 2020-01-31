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
        Global global = new Global();
        bool drag = true;
        Point start_point = new Point(0, 0);
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
            label_balance.Text = global.core.solo.balance.balance;
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
    }
}
