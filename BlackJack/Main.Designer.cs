namespace BlackJack
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.menu_solo = new MetroSet_UI.Controls.MetroSetButton();
            this.menu_multiplayer = new MetroSet_UI.Controls.MetroSetButton();
            this.menu_settings = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.label_title_game = new System.Windows.Forms.Label();
            this.animator_one = new System.Windows.Forms.Timer(this.components);
            this.logo_heart = new System.Windows.Forms.PictureBox();
            this.logo_cards = new System.Windows.Forms.PictureBox();
            this.animator_two = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo_heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_cards)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetControlBox1.Location = new System.Drawing.Point(0, 0);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // menu_solo
            // 
            this.menu_solo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menu_solo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_solo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_solo.DisabledForeColor = System.Drawing.Color.Gray;
            this.menu_solo.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.menu_solo.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.menu_solo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.menu_solo.HoverTextColor = System.Drawing.Color.White;
            this.menu_solo.Location = new System.Drawing.Point(317, 244);
            this.menu_solo.Name = "menu_solo";
            this.menu_solo.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_solo.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_solo.NormalTextColor = System.Drawing.Color.White;
            this.menu_solo.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.menu_solo.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.menu_solo.PressTextColor = System.Drawing.Color.White;
            this.menu_solo.Size = new System.Drawing.Size(359, 47);
            this.menu_solo.Style = MetroSet_UI.Design.Style.Light;
            this.menu_solo.StyleManager = null;
            this.menu_solo.TabIndex = 2;
            this.menu_solo.Text = "SOLO";
            this.menu_solo.ThemeAuthor = "Narwin";
            this.menu_solo.ThemeName = "MetroLite";
            this.menu_solo.Visible = false;
            this.menu_solo.Click += new System.EventHandler(this.menu_solo_Click);
            // 
            // menu_multiplayer
            // 
            this.menu_multiplayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menu_multiplayer.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_multiplayer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_multiplayer.DisabledForeColor = System.Drawing.Color.Gray;
            this.menu_multiplayer.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.menu_multiplayer.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.menu_multiplayer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.menu_multiplayer.HoverTextColor = System.Drawing.Color.White;
            this.menu_multiplayer.Location = new System.Drawing.Point(317, 297);
            this.menu_multiplayer.Name = "menu_multiplayer";
            this.menu_multiplayer.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_multiplayer.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_multiplayer.NormalTextColor = System.Drawing.Color.White;
            this.menu_multiplayer.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.menu_multiplayer.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.menu_multiplayer.PressTextColor = System.Drawing.Color.White;
            this.menu_multiplayer.Size = new System.Drawing.Size(359, 47);
            this.menu_multiplayer.Style = MetroSet_UI.Design.Style.Light;
            this.menu_multiplayer.StyleManager = null;
            this.menu_multiplayer.TabIndex = 3;
            this.menu_multiplayer.Text = "MULTIPLAYER";
            this.menu_multiplayer.ThemeAuthor = "Narwin";
            this.menu_multiplayer.ThemeName = "MetroLite";
            this.menu_multiplayer.Visible = false;
            this.menu_multiplayer.Click += new System.EventHandler(this.menu_multiplayer_Click);
            // 
            // menu_settings
            // 
            this.menu_settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menu_settings.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_settings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_settings.DisabledForeColor = System.Drawing.Color.Gray;
            this.menu_settings.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.menu_settings.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.menu_settings.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.menu_settings.HoverTextColor = System.Drawing.Color.White;
            this.menu_settings.Location = new System.Drawing.Point(317, 350);
            this.menu_settings.Name = "menu_settings";
            this.menu_settings.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_settings.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.menu_settings.NormalTextColor = System.Drawing.Color.White;
            this.menu_settings.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.menu_settings.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.menu_settings.PressTextColor = System.Drawing.Color.White;
            this.menu_settings.Size = new System.Drawing.Size(359, 47);
            this.menu_settings.Style = MetroSet_UI.Design.Style.Light;
            this.menu_settings.StyleManager = null;
            this.menu_settings.TabIndex = 4;
            this.menu_settings.Text = "SETTINGS";
            this.menu_settings.ThemeAuthor = "Narwin";
            this.menu_settings.ThemeName = "MetroLite";
            this.menu_settings.Visible = false;
            this.menu_settings.Click += new System.EventHandler(this.menu_settings_Click);
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroSetLabel2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.metroSetLabel2.Location = new System.Drawing.Point(0, 519);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(996, 31);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 5;
            this.metroSetLabel2.Text = "Song Playing: ";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.metroSetLabel3.Location = new System.Drawing.Point(795, 28);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(201, 31);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 6;
            this.metroSetLabel3.Text = "Project made by: Ivan Moroz";
            this.metroSetLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.metroSetPanel1.Location = new System.Drawing.Point(106, 0);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(890, 25);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 7;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroLite";
            this.metroSetPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroSetPanel1_MouseDown);
            this.metroSetPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroSetPanel1_MouseMove);
            this.metroSetPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.metroSetPanel1_MouseUp);
            // 
            // label_title_game
            // 
            this.label_title_game.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title_game.BackColor = System.Drawing.Color.Transparent;
            this.label_title_game.Font = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Bold);
            this.label_title_game.Location = new System.Drawing.Point(0, 59);
            this.label_title_game.Name = "label_title_game";
            this.label_title_game.Size = new System.Drawing.Size(996, 81);
            this.label_title_game.TabIndex = 10;
            this.label_title_game.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_title_game.Visible = false;
            // 
            // animator_one
            // 
            this.animator_one.Interval = 1000;
            this.animator_one.Tick += new System.EventHandler(this.animator_one_Tick);
            // 
            // logo_heart
            // 
            this.logo_heart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo_heart.BackColor = System.Drawing.Color.Transparent;
            this.logo_heart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo_heart.Image = global::BlackJack.Properties.Resources._061_poker_52;
            this.logo_heart.Location = new System.Drawing.Point(696, 76);
            this.logo_heart.Name = "logo_heart";
            this.logo_heart.Size = new System.Drawing.Size(64, 64);
            this.logo_heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_heart.TabIndex = 11;
            this.logo_heart.TabStop = false;
            this.logo_heart.Visible = false;
            // 
            // logo_cards
            // 
            this.logo_cards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo_cards.BackColor = System.Drawing.Color.Transparent;
            this.logo_cards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo_cards.Image = global::BlackJack.Properties.Resources._064_poker_55;
            this.logo_cards.Location = new System.Drawing.Point(238, 76);
            this.logo_cards.Name = "logo_cards";
            this.logo_cards.Size = new System.Drawing.Size(64, 64);
            this.logo_cards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_cards.TabIndex = 9;
            this.logo_cards.TabStop = false;
            this.logo_cards.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(996, 550);
            this.ControlBox = false;
            this.Controls.Add(this.logo_heart);
            this.Controls.Add(this.logo_cards);
            this.Controls.Add(this.label_title_game);
            this.Controls.Add(this.metroSetPanel1);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.menu_settings);
            this.Controls.Add(this.menu_multiplayer);
            this.Controls.Add(this.menu_solo);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetLabel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(996, 550);
            this.Name = "Menu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_cards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton menu_solo;
        private MetroSet_UI.Controls.MetroSetButton menu_multiplayer;
        private MetroSet_UI.Controls.MetroSetButton menu_settings;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private System.Windows.Forms.Label label_title_game;
        private System.Windows.Forms.Timer animator_one;
        private System.Windows.Forms.PictureBox logo_heart;
        private System.Windows.Forms.PictureBox logo_cards;
        private System.Windows.Forms.Timer animator_two;
    }
}

