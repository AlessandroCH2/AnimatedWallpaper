using H.NotifyIcon.Core;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace AnimatedWallpaper
{
    public partial class Wallpaper : Form
    {
        private IntPtr workerw;
        System.Windows.Forms.Timer timer;
        public VideoView videoView = null;
        public ContextMenuStrip contextMenu1 = new ContextMenuStrip();
        public static Wallpaper instance;
        public TrayIconWithContextMenu notifyIcon;
        public static Wallpaper Get()
        {
            return instance;
        }
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private string GetWindowTitle(IntPtr hWnd)
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(hWnd, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
        [DllImport("user32.dll")]
        static extern IntPtr GetActiveWindow();
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        private void tickEx(object? sender, EventArgs e)
        {
            bool isVisible = W32.IsWindowVisible(workerw);
            IntPtr handleTop = GetForegroundWindow();
            if (videoView.MediaPlayer == null)
            {
                
                return;
            }

            //Debug.WriteLine(GetWindowTitle(handleTop) +" - "+ GetWindowTitle(workerw));
            if (GetWindowTitle(handleTop) == null)
            {
                if (!videoView.MediaPlayer.IsPlaying)
                {
                    videoView.MediaPlayer.Play();
                }
            }
            else
            {
                if (videoView.MediaPlayer.IsPlaying)
                {
                    videoView.MediaPlayer.Pause();
                }
            }




        }

        public Wallpaper(IntPtr workerw)
        {
            instance = this;
            this.workerw = workerw;
            InitializeComponent();
            Core.Initialize();
            videoView = new VideoView();
            videoView.Dock = DockStyle.Fill;
            LibVLC _libVLC = new LibVLC("--input-repeat=100");

            try
            {
                MediaPlayer _mp = new MediaPlayer(_libVLC);

                _mp.Play(new Media(_libVLC, new Uri(File.ReadAllText("videoLink.txt"))));
                videoView.MediaPlayer = _mp;
            }
            catch (Exception ex)
            {

            }

            this.Controls.Add(videoView);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += tickEx;
            timer.Start();

            CreateNotifyIcon();


        }

        public void CreateNotifyIcon()
        {
         
            
            notifyIcon = new TrayIconWithContextMenu() { Icon=this.Icon.Handle};
            notifyIcon.UseStandardTooltip = true;
            notifyIcon.ToolTip = "Wallpaper Engine Beta";
           
            notifyIcon.Visibility = IconVisibility.Visible;
            notifyIcon.ContextMenu = new PopupMenu()
            {
                
                Items =
                {
                    new PopupMenuItem("Change Wallpaper",(_, _) => OpenWallpaperSelector()),
                     new PopupMenuSeparator(),
                    new PopupMenuItem("Made by Alessandro",null),
                    new PopupMenuSeparator(),
                    new PopupMenuItem("Exit",(_, _) => exit_Click())
                },
               
            };
            notifyIcon.Create();
          
            /* notifyIcon.DoubleClick += new System.EventHandler(this.OpenWallpaperSelector);
             notifyIcon.Icon = this.Icon;
             notifyIcon.ContextMenuStrip = contextMenu1;*/
        }
        // ...

        void exit_Click()
        {
            notifyIcon.Remove();
            notifyIcon.Dispose();
            Application.Exit();
            
        }
        

        private void OpenWallpaperSelector()
        {
            new WallpaperSelect().Show();
        }

        private void Wallpaper_Paint(object sender, PaintEventArgs e)
        {
            if (videoView.MediaPlayer == null)
            {
                using (Graphics g = e.Graphics)
                {
                    g.Clear(Color.White);
                    using (Pen p = new Pen(Color.White, 1))
                    {
                      
                        g.DrawString("No wallpaper found", this.Font, p.Brush,12,12);
                    }
                }

            }
            else
            {
                base.OnPaint(e);
            }
        }
    }
}
