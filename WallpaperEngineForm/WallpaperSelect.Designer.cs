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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 418);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(676, 23);
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
            applyButton.Location = new Point(694, 418);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(75, 23);
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
            wallpaperList.Size = new Size(757, 349);
            wallpaperList.TabIndex = 5;
            wallpaperList.SelectedValueChanged += wallpaperList_SelectedValueChanged;
            // 
            // browse
            // 
            browse.Location = new Point(694, 382);
            browse.Name = "browse";
            browse.Size = new Size(75, 23);
            browse.TabIndex = 6;
            browse.Text = "Browse";
            browse.UseVisualStyleBackColor = true;
            browse.Click += browse_Click;
            // 
            // reload
            // 
            reload.Location = new Point(613, 382);
            reload.Name = "reload";
            reload.Size = new Size(75, 23);
            reload.TabIndex = 7;
            reload.Text = "Reload";
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // WallpaperSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 453);
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
    }
}