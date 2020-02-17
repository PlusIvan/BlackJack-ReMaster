using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_ReMaster
{
    class Soundtrack
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private static string path_soundtrack = "";
        private static Boolean ismusic = false;
        private static string file = "";

        public string SoundTrack_FileName
        {
            get { return file; }
            set { file = value; }
        }
        public string SoundTrack_Path
        {
            get { return path_soundtrack; }
            set { path_soundtrack = value; }
        }
        public Boolean IsMusic
        {
            get { return ismusic; }
            set { ismusic = value; }
        }

        public void Play()
        {
            wplayer.URL = $@"{SoundTrack_Path}\{file.ToString()}";
            wplayer.controls.play();
        }

        public void Reset()
        {
            wplayer.controls.stop();
            IsMusic = false;
        }
        public void Pause()
        {
            wplayer.controls.pause();
        }
        public void Previous()
        {
            wplayer.controls.previous();
        }
        public void Next()
        {
            wplayer.controls.next();
        }
    }
}
