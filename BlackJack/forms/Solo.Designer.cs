namespace BlackJack.forms
{
    partial class Solo
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
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.label_balance = new MetroSet_UI.Controls.MetroSetLabel();
            this.pot_size = new MetroSet_UI.Controls.MetroSetLabel();
            this.dealer_pts = new MetroSet_UI.Controls.MetroSetBadge();
            this.player_pts = new MetroSet_UI.Controls.MetroSetBadge();
            this.animate_chips = new System.Windows.Forms.Timer(this.components);
            this.panel_chips = new MetroSet_UI.Controls.MetroSetPanel();
            this.cmd_Done = new MetroSet_UI.Controls.MetroSetButton();
            this.chip_minus = new System.Windows.Forms.PictureBox();
            this.chip_plus = new System.Windows.Forms.PictureBox();
            this.chip_15 = new System.Windows.Forms.PictureBox();
            this.chip_10 = new System.Windows.Forms.PictureBox();
            this.chip_100 = new System.Windows.Forms.PictureBox();
            this.chip_50 = new System.Windows.Forms.PictureBox();
            this.chip_5 = new System.Windows.Forms.PictureBox();
            this.solo_begin = new MetroSet_UI.Controls.MetroSetButton();
            this.solo_title = new MetroSet_UI.Controls.MetroSetLabel();
            this.card_l_player = new System.Windows.Forms.PictureBox();
            this.balance_plus = new System.Windows.Forms.PictureBox();
            this.card_l_dealer = new System.Windows.Forms.PictureBox();
            this.balance_minus = new System.Windows.Forms.PictureBox();
            this.balance_icon = new System.Windows.Forms.PictureBox();
            this.cmd_Stand = new MetroSet_UI.Controls.MetroSetButton();
            this.cmd_Hit = new MetroSet_UI.Controls.MetroSetButton();
            this.cmd_Double = new MetroSet_UI.Controls.MetroSetButton();
            this.cmd_Surrender = new MetroSet_UI.Controls.MetroSetButton();
            this.panel_chips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chip_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_l_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_l_dealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_icon)).BeginInit();
            this.SuspendLayout();
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
            this.metroSetPanel1.Size = new System.Drawing.Size(893, 25);
            this.metroSetPanel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 9;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroLite";
            this.metroSetPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroSetPanel1_MouseDown);
            this.metroSetPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroSetPanel1_MouseMove);
            this.metroSetPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.metroSetPanel1_MouseUp);
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
            this.metroSetControlBox1.TabIndex = 8;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // label_balance
            // 
            this.label_balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_balance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label_balance.Location = new System.Drawing.Point(82, 495);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(905, 64);
            this.label_balance.Style = MetroSet_UI.Design.Style.Light;
            this.label_balance.StyleManager = null;
            this.label_balance.TabIndex = 13;
            this.label_balance.Text = "Balance: 0";
            this.label_balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_balance.ThemeAuthor = "Narwin";
            this.label_balance.ThemeName = "MetroLite";
            this.label_balance.Visible = false;
            this.label_balance.TextChanged += new System.EventHandler(this.label_balance_TextChanged);
            // 
            // pot_size
            // 
            this.pot_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pot_size.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.pot_size.Location = new System.Drawing.Point(226, 292);
            this.pot_size.Name = "pot_size";
            this.pot_size.Size = new System.Drawing.Size(546, 54);
            this.pot_size.Style = MetroSet_UI.Design.Style.Light;
            this.pot_size.StyleManager = null;
            this.pot_size.TabIndex = 19;
            this.pot_size.Text = "Pot: 0";
            this.pot_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pot_size.ThemeAuthor = "Narwin";
            this.pot_size.ThemeName = "MetroLite";
            this.pot_size.Visible = false;
            // 
            // dealer_pts
            // 
            this.dealer_pts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dealer_pts.BackColor = System.Drawing.Color.Transparent;
            this.dealer_pts.BadgeAlignment = MetroSet_UI.Enums.BadgeAlign.TopRight;
            this.dealer_pts.BadgeText = "0";
            this.dealer_pts.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dealer_pts.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.dealer_pts.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.dealer_pts.Enabled = false;
            this.dealer_pts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dealer_pts.HoverBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(187)))), ((int)(((byte)(245)))));
            this.dealer_pts.HoverBadgeTextColor = System.Drawing.Color.White;
            this.dealer_pts.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dealer_pts.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dealer_pts.HoverTextColor = System.Drawing.Color.White;
            this.dealer_pts.Location = new System.Drawing.Point(431, 36);
            this.dealer_pts.Name = "dealer_pts";
            this.dealer_pts.NormalBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.dealer_pts.NormalBadgeTextColor = System.Drawing.Color.White;
            this.dealer_pts.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dealer_pts.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dealer_pts.NormalTextColor = System.Drawing.Color.Black;
            this.dealer_pts.PressBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(147)))), ((int)(((byte)(205)))));
            this.dealer_pts.PressBadgeTextColor = System.Drawing.Color.White;
            this.dealer_pts.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dealer_pts.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dealer_pts.PressTextColor = System.Drawing.Color.White;
            this.dealer_pts.Size = new System.Drawing.Size(137, 45);
            this.dealer_pts.Style = MetroSet_UI.Design.Style.Light;
            this.dealer_pts.StyleManager = null;
            this.dealer_pts.TabIndex = 28;
            this.dealer_pts.Text = "Dealer";
            this.dealer_pts.ThemeAuthor = "Narwin";
            this.dealer_pts.ThemeName = "MetroLite";
            this.dealer_pts.Visible = false;
            // 
            // player_pts
            // 
            this.player_pts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player_pts.BackColor = System.Drawing.Color.Transparent;
            this.player_pts.BadgeAlignment = MetroSet_UI.Enums.BadgeAlign.TopRight;
            this.player_pts.BadgeText = "0";
            this.player_pts.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.player_pts.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.player_pts.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.player_pts.Enabled = false;
            this.player_pts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.player_pts.HoverBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(187)))), ((int)(((byte)(245)))));
            this.player_pts.HoverBadgeTextColor = System.Drawing.Color.White;
            this.player_pts.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.player_pts.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.player_pts.HoverTextColor = System.Drawing.Color.White;
            this.player_pts.Location = new System.Drawing.Point(431, 174);
            this.player_pts.Name = "player_pts";
            this.player_pts.NormalBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.player_pts.NormalBadgeTextColor = System.Drawing.Color.White;
            this.player_pts.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.player_pts.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.player_pts.NormalTextColor = System.Drawing.Color.Black;
            this.player_pts.PressBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(147)))), ((int)(((byte)(205)))));
            this.player_pts.PressBadgeTextColor = System.Drawing.Color.White;
            this.player_pts.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.player_pts.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.player_pts.PressTextColor = System.Drawing.Color.White;
            this.player_pts.Size = new System.Drawing.Size(137, 45);
            this.player_pts.Style = MetroSet_UI.Design.Style.Light;
            this.player_pts.StyleManager = null;
            this.player_pts.TabIndex = 29;
            this.player_pts.Text = "You";
            this.player_pts.ThemeAuthor = "Narwin";
            this.player_pts.ThemeName = "MetroLite";
            this.player_pts.Visible = false;
            // 
            // animate_chips
            // 
            this.animate_chips.Interval = 500;
            this.animate_chips.Tick += new System.EventHandler(this.animate_chips_Tick);
            // 
            // panel_chips
            // 
            this.panel_chips.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_chips.BackgroundColor = System.Drawing.Color.White;
            this.panel_chips.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel_chips.BorderThickness = 1;
            this.panel_chips.Controls.Add(this.cmd_Done);
            this.panel_chips.Controls.Add(this.chip_minus);
            this.panel_chips.Controls.Add(this.chip_plus);
            this.panel_chips.Location = new System.Drawing.Point(223, 366);
            this.panel_chips.MinimumSize = new System.Drawing.Size(552, 0);
            this.panel_chips.Name = "panel_chips";
            this.panel_chips.Size = new System.Drawing.Size(552, 82);
            this.panel_chips.Style = MetroSet_UI.Design.Style.Light;
            this.panel_chips.StyleManager = null;
            this.panel_chips.TabIndex = 34;
            this.panel_chips.ThemeAuthor = "Narwin";
            this.panel_chips.ThemeName = "MetroLite";
            this.panel_chips.Visible = false;
            // 
            // cmd_Done
            // 
            this.cmd_Done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Done.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Done.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Done.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmd_Done.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.cmd_Done.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmd_Done.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmd_Done.HoverTextColor = System.Drawing.Color.White;
            this.cmd_Done.Location = new System.Drawing.Point(146, 24);
            this.cmd_Done.Name = "cmd_Done";
            this.cmd_Done.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Done.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Done.NormalTextColor = System.Drawing.Color.White;
            this.cmd_Done.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmd_Done.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmd_Done.PressTextColor = System.Drawing.Color.White;
            this.cmd_Done.Size = new System.Drawing.Size(400, 42);
            this.cmd_Done.Style = MetroSet_UI.Design.Style.Light;
            this.cmd_Done.StyleManager = null;
            this.cmd_Done.TabIndex = 40;
            this.cmd_Done.Text = "DONE";
            this.cmd_Done.ThemeAuthor = "Narwin";
            this.cmd_Done.ThemeName = "MetroLite";
            this.cmd_Done.Click += new System.EventHandler(this.cmd_Done_Click);
            // 
            // chip_minus
            // 
            this.chip_minus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chip_minus.BackColor = System.Drawing.Color.Transparent;
            this.chip_minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chip_minus.Image = global::BlackJack.Properties.Resources._053_casino;
            this.chip_minus.Location = new System.Drawing.Point(6, 15);
            this.chip_minus.Name = "chip_minus";
            this.chip_minus.Size = new System.Drawing.Size(64, 64);
            this.chip_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chip_minus.TabIndex = 33;
            this.chip_minus.TabStop = false;
            this.chip_minus.Click += new System.EventHandler(this.chip_minus_Click);
            // 
            // chip_plus
            // 
            this.chip_plus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chip_plus.BackColor = System.Drawing.Color.Transparent;
            this.chip_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chip_plus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chip_plus.Image = global::BlackJack.Properties.Resources._054_chip;
            this.chip_plus.Location = new System.Drawing.Point(76, 15);
            this.chip_plus.Name = "chip_plus";
            this.chip_plus.Size = new System.Drawing.Size(64, 64);
            this.chip_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chip_plus.TabIndex = 23;
            this.chip_plus.TabStop = false;
            this.chip_plus.Click += new System.EventHandler(this.chip_plus_Click);
            // 
            // chip_15
            // 
            this.chip_15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chip_15.BackColor = System.Drawing.Color.Transparent;
            this.chip_15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chip_15.Image = global::BlackJack.Properties.Resources._055_chip_1;
            this.chip_15.Location = new System.Drawing.Point(299, 296);
            this.chip_15.Name = "chip_15";
            this.chip_15.Size = new System.Drawing.Size(64, 64);
            this.chip_15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chip_15.TabIndex = 18;
            this.chip_15.TabStop = false;
            this.chip_15.Visible = false;
            this.chip_15.Click += new System.EventHandler(this.chip_15_Click);
            this.chip_15.MouseLeave += new System.EventHandler(this.chip_MouseLeave);
            this.chip_15.MouseHover += new System.EventHandler(this.chip_MouseHover);
            // 
            // chip_10
            // 
            this.chip_10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chip_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chip_10.Image = global::BlackJack.Properties.Resources._060_casino_2;
            this.chip_10.Location = new System.Drawing.Point(229, 311);
            this.chip_10.Name = "chip_10";
            this.chip_10.Size = new System.Drawing.Size(64, 64);
            this.chip_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chip_10.TabIndex = 14;
            this.chip_10.TabStop = false;
            this.chip_10.Visible = false;
            this.chip_10.Click += new System.EventHandler(this.chip_10_Click);
            this.chip_10.MouseLeave += new System.EventHandler(this.chip_MouseLeave);
            this.chip_10.MouseHover += new System.EventHandler(this.chip_MouseHover);
            // 
            // chip_100
            // 
            this.chip_100.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chip_100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chip_100.Image = global::BlackJack.Properties.Resources._059_bet;
            this.chip_100.Location = new System.Drawing.Point(159, 311);
            this.chip_100.Name = "chip_100";
            this.chip_100.Size = new System.Drawing.Size(64, 64);
            this.chip_100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chip_100.TabIndex = 15;
            this.chip_100.TabStop = false;
            this.chip_100.Visible = false;
            this.chip_100.Click += new System.EventHandler(this.chip_100_Click);
            this.chip_100.MouseLeave += new System.EventHandler(this.chip_MouseLeave);
            this.chip_100.MouseHover += new System.EventHandler(this.chip_MouseHover);
            // 
            // chip_50
            // 
            this.chip_50.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chip_50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chip_50.Image = global::BlackJack.Properties.Resources._057_chip_3;
            this.chip_50.Location = new System.Drawing.Point(263, 451);
            this.chip_50.Name = "chip_50";
            this.chip_50.Size = new System.Drawing.Size(64, 64);
            this.chip_50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chip_50.TabIndex = 16;
            this.chip_50.TabStop = false;
            this.chip_50.Visible = false;
            this.chip_50.Click += new System.EventHandler(this.chip_50_Click);
            this.chip_50.MouseLeave += new System.EventHandler(this.chip_MouseLeave);
            this.chip_50.MouseHover += new System.EventHandler(this.chip_MouseHover);
            // 
            // chip_5
            // 
            this.chip_5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chip_5.BackColor = System.Drawing.Color.Transparent;
            this.chip_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chip_5.Image = global::BlackJack.Properties.Resources._056_chip_2;
            this.chip_5.Location = new System.Drawing.Point(313, 454);
            this.chip_5.Name = "chip_5";
            this.chip_5.Size = new System.Drawing.Size(64, 64);
            this.chip_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chip_5.TabIndex = 17;
            this.chip_5.TabStop = false;
            this.chip_5.Visible = false;
            this.chip_5.Click += new System.EventHandler(this.chip_5_Click);
            this.chip_5.MouseLeave += new System.EventHandler(this.chip_MouseLeave);
            this.chip_5.MouseHover += new System.EventHandler(this.chip_MouseHover);
            // 
            // solo_begin
            // 
            this.solo_begin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.solo_begin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.solo_begin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.solo_begin.DisabledForeColor = System.Drawing.Color.Gray;
            this.solo_begin.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.solo_begin.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.solo_begin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.solo_begin.HoverTextColor = System.Drawing.Color.White;
            this.solo_begin.Location = new System.Drawing.Point(0, 199);
            this.solo_begin.Name = "solo_begin";
            this.solo_begin.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.solo_begin.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.solo_begin.NormalTextColor = System.Drawing.Color.White;
            this.solo_begin.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.solo_begin.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.solo_begin.PressTextColor = System.Drawing.Color.White;
            this.solo_begin.Size = new System.Drawing.Size(999, 68);
            this.solo_begin.Style = MetroSet_UI.Design.Style.Light;
            this.solo_begin.StyleManager = null;
            this.solo_begin.TabIndex = 36;
            this.solo_begin.Text = "Start Game";
            this.solo_begin.ThemeAuthor = "Narwin";
            this.solo_begin.ThemeName = "MetroLite";
            this.solo_begin.Click += new System.EventHandler(this.solo_begin_Click);
            // 
            // solo_title
            // 
            this.solo_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.solo_title.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Italic);
            this.solo_title.Location = new System.Drawing.Point(0, 84);
            this.solo_title.Name = "solo_title";
            this.solo_title.Size = new System.Drawing.Size(999, 92);
            this.solo_title.Style = MetroSet_UI.Design.Style.Light;
            this.solo_title.StyleManager = null;
            this.solo_title.TabIndex = 37;
            this.solo_title.Text = "Solo";
            this.solo_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.solo_title.ThemeAuthor = "Narwin";
            this.solo_title.ThemeName = "MetroLite";
            // 
            // card_l_player
            // 
            this.card_l_player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.card_l_player.BackColor = System.Drawing.Color.Transparent;
            this.card_l_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.card_l_player.Image = global::BlackJack.Properties.Resources.poker;
            this.card_l_player.Location = new System.Drawing.Point(431, 225);
            this.card_l_player.Name = "card_l_player";
            this.card_l_player.Size = new System.Drawing.Size(64, 64);
            this.card_l_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card_l_player.TabIndex = 35;
            this.card_l_player.TabStop = false;
            this.card_l_player.Tag = "";
            this.card_l_player.Visible = false;
            // 
            // balance_plus
            // 
            this.balance_plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balance_plus.BackColor = System.Drawing.Color.Transparent;
            this.balance_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.balance_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balance_plus.Image = global::BlackJack.Properties.Resources._054_chip;
            this.balance_plus.Location = new System.Drawing.Point(12, 425);
            this.balance_plus.Name = "balance_plus";
            this.balance_plus.Size = new System.Drawing.Size(64, 64);
            this.balance_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balance_plus.TabIndex = 32;
            this.balance_plus.TabStop = false;
            this.balance_plus.Visible = false;
            this.balance_plus.Click += new System.EventHandler(this.balance_plus_Click);
            // 
            // card_l_dealer
            // 
            this.card_l_dealer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.card_l_dealer.BackColor = System.Drawing.Color.Transparent;
            this.card_l_dealer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.card_l_dealer.Image = global::BlackJack.Properties.Resources.poker;
            this.card_l_dealer.Location = new System.Drawing.Point(431, 87);
            this.card_l_dealer.Name = "card_l_dealer";
            this.card_l_dealer.Size = new System.Drawing.Size(64, 64);
            this.card_l_dealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card_l_dealer.TabIndex = 25;
            this.card_l_dealer.TabStop = false;
            this.card_l_dealer.Tag = "";
            this.card_l_dealer.Visible = false;
            // 
            // balance_minus
            // 
            this.balance_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balance_minus.BackColor = System.Drawing.Color.Transparent;
            this.balance_minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.balance_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balance_minus.Image = global::BlackJack.Properties.Resources._053_casino;
            this.balance_minus.Location = new System.Drawing.Point(12, 355);
            this.balance_minus.Name = "balance_minus";
            this.balance_minus.Size = new System.Drawing.Size(64, 64);
            this.balance_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balance_minus.TabIndex = 24;
            this.balance_minus.TabStop = false;
            this.balance_minus.Visible = false;
            this.balance_minus.Click += new System.EventHandler(this.balance_minus_Click);
            // 
            // balance_icon
            // 
            this.balance_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balance_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.balance_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balance_icon.Image = global::BlackJack.Properties.Resources._058_casino_1;
            this.balance_icon.Location = new System.Drawing.Point(12, 495);
            this.balance_icon.Name = "balance_icon";
            this.balance_icon.Size = new System.Drawing.Size(64, 64);
            this.balance_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balance_icon.TabIndex = 12;
            this.balance_icon.TabStop = false;
            this.balance_icon.Visible = false;
            this.balance_icon.Click += new System.EventHandler(this.balance_icon_Click);
            // 
            // cmd_Stand
            // 
            this.cmd_Stand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_Stand.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Stand.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Stand.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmd_Stand.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.cmd_Stand.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmd_Stand.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmd_Stand.HoverTextColor = System.Drawing.Color.White;
            this.cmd_Stand.Location = new System.Drawing.Point(383, 349);
            this.cmd_Stand.Name = "cmd_Stand";
            this.cmd_Stand.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Stand.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Stand.NormalTextColor = System.Drawing.Color.White;
            this.cmd_Stand.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmd_Stand.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmd_Stand.PressTextColor = System.Drawing.Color.White;
            this.cmd_Stand.Size = new System.Drawing.Size(232, 42);
            this.cmd_Stand.Style = MetroSet_UI.Design.Style.Light;
            this.cmd_Stand.StyleManager = null;
            this.cmd_Stand.TabIndex = 38;
            this.cmd_Stand.Text = "STAND";
            this.cmd_Stand.ThemeAuthor = "Narwin";
            this.cmd_Stand.ThemeName = "MetroLite";
            this.cmd_Stand.Visible = false;
            this.cmd_Stand.Click += new System.EventHandler(this.cmd_Stand_Click);
            // 
            // cmd_Hit
            // 
            this.cmd_Hit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_Hit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Hit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Hit.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmd_Hit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.cmd_Hit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmd_Hit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmd_Hit.HoverTextColor = System.Drawing.Color.White;
            this.cmd_Hit.Location = new System.Drawing.Point(383, 397);
            this.cmd_Hit.Name = "cmd_Hit";
            this.cmd_Hit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Hit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Hit.NormalTextColor = System.Drawing.Color.White;
            this.cmd_Hit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmd_Hit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmd_Hit.PressTextColor = System.Drawing.Color.White;
            this.cmd_Hit.Size = new System.Drawing.Size(232, 42);
            this.cmd_Hit.Style = MetroSet_UI.Design.Style.Light;
            this.cmd_Hit.StyleManager = null;
            this.cmd_Hit.TabIndex = 39;
            this.cmd_Hit.Text = "HIT";
            this.cmd_Hit.ThemeAuthor = "Narwin";
            this.cmd_Hit.ThemeName = "MetroLite";
            this.cmd_Hit.Visible = false;
            this.cmd_Hit.Click += new System.EventHandler(this.cmd_Hit_Click);
            // 
            // cmd_Double
            // 
            this.cmd_Double.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_Double.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Double.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Double.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmd_Double.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.cmd_Double.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmd_Double.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmd_Double.HoverTextColor = System.Drawing.Color.White;
            this.cmd_Double.Location = new System.Drawing.Point(383, 445);
            this.cmd_Double.Name = "cmd_Double";
            this.cmd_Double.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Double.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Double.NormalTextColor = System.Drawing.Color.White;
            this.cmd_Double.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmd_Double.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmd_Double.PressTextColor = System.Drawing.Color.White;
            this.cmd_Double.Size = new System.Drawing.Size(232, 42);
            this.cmd_Double.Style = MetroSet_UI.Design.Style.Light;
            this.cmd_Double.StyleManager = null;
            this.cmd_Double.TabIndex = 40;
            this.cmd_Double.Text = "DOUBLE";
            this.cmd_Double.ThemeAuthor = "Narwin";
            this.cmd_Double.ThemeName = "MetroLite";
            this.cmd_Double.Visible = false;
            // 
            // cmd_Surrender
            // 
            this.cmd_Surrender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_Surrender.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Surrender.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Surrender.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmd_Surrender.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.cmd_Surrender.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmd_Surrender.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmd_Surrender.HoverTextColor = System.Drawing.Color.White;
            this.cmd_Surrender.Location = new System.Drawing.Point(383, 493);
            this.cmd_Surrender.Name = "cmd_Surrender";
            this.cmd_Surrender.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Surrender.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmd_Surrender.NormalTextColor = System.Drawing.Color.White;
            this.cmd_Surrender.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmd_Surrender.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmd_Surrender.PressTextColor = System.Drawing.Color.White;
            this.cmd_Surrender.Size = new System.Drawing.Size(232, 42);
            this.cmd_Surrender.Style = MetroSet_UI.Design.Style.Light;
            this.cmd_Surrender.StyleManager = null;
            this.cmd_Surrender.TabIndex = 41;
            this.cmd_Surrender.Text = "SURRENDER";
            this.cmd_Surrender.ThemeAuthor = "Narwin";
            this.cmd_Surrender.ThemeName = "MetroLite";
            this.cmd_Surrender.Visible = false;
            this.cmd_Surrender.Click += new System.EventHandler(this.cmd_Surrender_Click);
            // 
            // Solo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 568);
            this.Controls.Add(this.cmd_Surrender);
            this.Controls.Add(this.cmd_Hit);
            this.Controls.Add(this.chip_5);
            this.Controls.Add(this.chip_50);
            this.Controls.Add(this.chip_100);
            this.Controls.Add(this.chip_10);
            this.Controls.Add(this.chip_15);
            this.Controls.Add(this.cmd_Double);
            this.Controls.Add(this.cmd_Stand);
            this.Controls.Add(this.solo_title);
            this.Controls.Add(this.pot_size);
            this.Controls.Add(this.solo_begin);
            this.Controls.Add(this.card_l_player);
            this.Controls.Add(this.balance_plus);
            this.Controls.Add(this.player_pts);
            this.Controls.Add(this.dealer_pts);
            this.Controls.Add(this.card_l_dealer);
            this.Controls.Add(this.balance_minus);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.balance_icon);
            this.Controls.Add(this.metroSetPanel1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.panel_chips);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(999, 568);
            this.Name = "Solo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Solo_Load);
            this.panel_chips.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chip_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_l_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_l_dealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.PictureBox balance_icon;
        private MetroSet_UI.Controls.MetroSetLabel label_balance;
        private System.Windows.Forms.PictureBox chip_10;
        private System.Windows.Forms.PictureBox chip_100;
        private System.Windows.Forms.PictureBox chip_50;
        private System.Windows.Forms.PictureBox chip_5;
        private System.Windows.Forms.PictureBox chip_15;
        private MetroSet_UI.Controls.MetroSetLabel pot_size;
        private System.Windows.Forms.PictureBox balance_minus;
        private System.Windows.Forms.PictureBox chip_plus;
        private System.Windows.Forms.PictureBox card_l_dealer;
        private MetroSet_UI.Controls.MetroSetBadge dealer_pts;
        private MetroSet_UI.Controls.MetroSetBadge player_pts;
        private System.Windows.Forms.Timer animate_chips;
        private System.Windows.Forms.PictureBox balance_plus;
        private System.Windows.Forms.PictureBox chip_minus;
        private MetroSet_UI.Controls.MetroSetPanel panel_chips;
        private System.Windows.Forms.PictureBox card_l_player;
        private MetroSet_UI.Controls.MetroSetButton solo_begin;
        private MetroSet_UI.Controls.MetroSetLabel solo_title;
        private MetroSet_UI.Controls.MetroSetButton cmd_Hit;
        private MetroSet_UI.Controls.MetroSetButton cmd_Stand;
        private MetroSet_UI.Controls.MetroSetButton cmd_Double;
        private MetroSet_UI.Controls.MetroSetButton cmd_Surrender;
        private MetroSet_UI.Controls.MetroSetButton cmd_Done;
    }
}