using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimatedWallpaper
{
    public partial class WallpaperSelect : Form
    {
        public WallpaperSelect()
        {
            InitializeComponent();
            try
            {
                textBox1.Text = File.ReadAllText("videoLink.txt");
            }
            catch(Exception ex) { }

            

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("videoLink.txt",textBox1.Text);
            LibVLC _libVLC = new LibVLC("--input-repeat=100");
            if(Wallpaper.Get().videoView.MediaPlayer == null)
            {
                MediaPlayer _mp = new MediaPlayer(_libVLC);


                Wallpaper.Get().videoView.MediaPlayer = _mp;
            }
           
            Wallpaper.Get().videoView.MediaPlayer.Play(new Media(_libVLC, new Uri(File.ReadAllText("videoLink.txt"))));
            Wallpaper.Get().notifyIcon.ShowNotification("Wallpaper Engine", "Wallpaper changed in "+ File.ReadAllText("videoLink.txt"));
        }
    }
}
