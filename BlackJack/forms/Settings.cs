using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack.forms
{
    public partial class Settings : Form
    {
        bool drag = true;
        Point start_point = new Point(0, 0);
        public Settings()
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

        private void btn_loadPATH_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                input_trackPATH.Text = dialog.FileName;



            string[] list = Directory.GetFiles(input_trackPATH.Text, "*.mp3");
            combo_musics.Items.Clear();
            foreach(string l in list)
                combo_musics.Items.Add(Path.GetFileName(l));
        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private void music_play_Click(object sender, EventArgs e)
        {
            wplayer.URL = $@"{input_trackPATH.Text}\{combo_musics.SelectedItem.ToString()}";
            wplayer.controls.play();

        }

        private void music_stop_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }
    }
}
