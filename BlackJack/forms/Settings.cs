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
        Solo_game game = new Solo_game();
        Soundtrack soundtrack = new Soundtrack();
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
            soundtrack.SoundTrack_Path = input_trackPATH.Text;

            string[] list = Directory.GetFiles(soundtrack.SoundTrack_Path, "*.mp3");
            combo_musics.Items.Clear();
            foreach(string l in list)
                combo_musics.Items.Add(Path.GetFileName(l));
        }
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private void music_play_Click(object sender, EventArgs e)
        {
            wplayer.URL = $@"{soundtrack.SoundTrack_Path}\{combo_musics.SelectedItem.ToString()}";
            wplayer.controls.play();
            soundtrack.IsMusic = true;
        }

        private void music_stop_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            soundtrack.IsMusic = false;
        }

        private void metroSetTrackBar1_MouseHover(object sender, EventArgs e)
        {
            deck_qty.Text = metroSetTrackBar1.Value.ToString();

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            //appeal change
            game.Decks = metroSetTrackBar1.Value;
            game.IsRoyals = solo_setting_royals.Switched;
            game.IsJoker = solo_setting_joker.Switched;

            

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            metroSetTrackBar1.Value = game.Decks;
            solo_setting_royals.Switched = game.IsRoyals;
            solo_setting_joker.Switched = game.IsJoker;
            deck_qty.Text = metroSetTrackBar1.Value.ToString();
            input_trackPATH.Text = soundtrack.SoundTrack_Path;

            if (input_trackPATH.Text == "") return;
            string[] list = Directory.GetFiles(soundtrack.SoundTrack_Path, "*.mp3");
            combo_musics.Items.Clear();
            foreach (string l in list)
                combo_musics.Items.Add(Path.GetFileName(l));

        }
    }
}
