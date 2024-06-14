namespace AnimatedWallpaper
{
    partial class WallpaperSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            applyButton = new Button();
            label2 = new Label();
            wallpaperList = new ListBox();
            browse = new Button();
            reload = new Button();
            previewPlayer = new LibVLCSharp.WinForms.VideoView();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)previewPlayer).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 418);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(842, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 400);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Wallpaper Link";
            // 
            // applyButton
            // 
            applyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            applyButton.Location = new Point(613, 195);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(241, 36);
            applyButton.TabIndex = 2;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 3;
            label2.Text = "All wallpapers";
            // 
            // wallpaperList
            // 
            wallpaperList.FormattingEnabled = true;
            wallpaperList.ItemHeight = 15;
            wallpaperList.Location = new Point(12, 27);
            wallpaperList.Name = "wallpaperList";
            wallpaperList.Size = new Size(587, 349);
            wallpaperList.TabIndex = 5;
            wallpaperList.SelectedValueChanged += wallpaperList_SelectedValueChanged;
            // 
            // browse
            // 
            browse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            browse.Location = new Point(613, 279);
            browse.Name = "browse";
            browse.Size = new Size(241, 36);
            browse.TabIndex = 6;
            browse.Text = "Browse More...";
            browse.UseVisualStyleBackColor = true;
            browse.Click += browse_Click;
            // 
            // reload
            // 
            reload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            reload.Location = new Point(524, 382);
            reload.Name = "reload";
            reload.Size = new Size(75, 23);
            reload.TabIndex = 7;
            reload.Text = "Reload";
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // previewPlayer
            // 
            previewPlayer.BackColor = Color.Black;
            previewPlayer.Location = new Point(613, 27);
            previewPlayer.MediaPlayer = null;
            previewPlayer.Name = "previewPlayer";
            previewPlayer.Size = new Size(241, 135);
            previewPlayer.TabIndex = 8;
            previewPlayer.Text = "videoView1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(613, 165);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 9;
            label3.Text = "Preview";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(613, 237);
            button1.Name = "button1";
            button1.Size = new Size(241, 36);
            button1.TabIndex = 10;
            button1.Text = "Open Folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WallpaperSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 453);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(previewPlayer);
            Controls.Add(reload);
            Controls.Add(browse);
            Controls.Add(wallpaperList);
            Controls.Add(label2);
            Controls.Add(applyButton);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "WallpaperSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Wallpaper";
            Load += WallpaperSelect_Load;
            ((System.ComponentModel.ISupportInitialize)previewPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button applyButton;
        private Label label2;
        private ListBox wallpaperList;
        private Button browse;
        private Button reload;
        private LibVLCSharp.WinForms.VideoView previewPlayer;
        private Label label3;
        private Button button1;
    }
}