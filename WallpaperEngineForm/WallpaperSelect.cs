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
            catch (Exception ex) { }



        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("videoLink.txt", textBox1.Text);
            LibVLC _libVLC = new LibVLC("--input-repeat=100");
            if (Wallpaper.Get().videoView.MediaPlayer == null)
            {
                MediaPlayer _mp = new MediaPlayer(_libVLC);


                Wallpaper.Get().videoView.MediaPlayer = _mp;
            }

            Wallpaper.Get().videoView.MediaPlayer.Play(new Media(_libVLC, new Uri(File.ReadAllText("videoLink.txt"))));
            Wallpaper.Get().notifyIcon.ShowNotification("Wallpaper Engine", "Wallpaper changed in " + File.ReadAllText("videoLink.txt"));
        }

        private void WallpaperSelect_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("Wallpapers");
            foreach (string file in files)
            {


                wallpaperList.Items.Add(file);
            }
        }



        private void wallpaperList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (wallpaperList.SelectedItems.Count == 0) return;
            string text = wallpaperList.SelectedItem.ToString();
            textBox1.Text = Path.GetFullPath(text);
        }

        private void browse_Click(object sender, EventArgs e)
        {

        }

        private void reload_Click(object sender, EventArgs e)
        {
            wallpaperList.Items.Clear();
            string[] files = Directory.GetFiles("Wallpapers");
            foreach (string file in files)
            {


                wallpaperList.Items.Add(file);
            }
        }
    }
}
