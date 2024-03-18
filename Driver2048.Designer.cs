namespace Driver2048
{
    partial class Driver2048
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Driver2048));
            this.Khat4 = new System.Windows.Forms.GroupBox();
            this.Enemy = new System.Windows.Forms.Timer(this.components);
            this.Khat1 = new System.Windows.Forms.GroupBox();
            this.Khat2 = new System.Windows.Forms.GroupBox();
            this.Khat3 = new System.Windows.Forms.GroupBox();
            this.Khat5 = new System.Windows.Forms.GroupBox();
            this.Khat6 = new System.Windows.Forms.GroupBox();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Score = new System.Windows.Forms.Label();
            this.EnemyBox = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Khat4
            // 
            this.Khat4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Khat4.CausesValidation = false;
            this.Khat4.Enabled = false;
            this.Khat4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Khat4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Khat4.Location = new System.Drawing.Point(180, 327);
            this.Khat4.Name = "Khat4";
            this.Khat4.Size = new System.Drawing.Size(31, 160);
            this.Khat4.TabIndex = 0;
            this.Khat4.TabStop = false;
            this.Khat4.UseCompatibleTextRendering = true;
            // 
            // Enemy
            // 
            this.Enemy.Interval = 8;
            this.Enemy.Tick += new System.EventHandler(this.Enemy_Tick);
            // 
            // Khat1
            // 
            this.Khat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Khat1.Location = new System.Drawing.Point(25, 307);
            this.Khat1.Name = "Khat1";
            this.Khat1.Size = new System.Drawing.Size(31, 147);
            this.Khat1.TabIndex = 1;
            this.Khat1.TabStop = false;
            // 
            // Khat2
            // 
            this.Khat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Khat2.Location = new System.Drawing.Point(25, 50);
            this.Khat2.Name = "Khat2";
            this.Khat2.Size = new System.Drawing.Size(31, 149);
            this.Khat2.TabIndex = 2;
            this.Khat2.TabStop = false;
            // 
            // Khat3
            // 
            this.Khat3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Khat3.Location = new System.Drawing.Point(180, 59);
            this.Khat3.Name = "Khat3";
            this.Khat3.Size = new System.Drawing.Size(31, 163);
            this.Khat3.TabIndex = 3;
            this.Khat3.TabStop = false;
            // 
            // Khat5
            // 
            this.Khat5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Khat5.Location = new System.Drawing.Point(335, 31);
            this.Khat5.Name = "Khat5";
            this.Khat5.Size = new System.Drawing.Size(31, 147);
            this.Khat5.TabIndex = 4;
            this.Khat5.TabStop = false;
            // 
            // Khat6
            // 
            this.Khat6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Khat6.Location = new System.Drawing.Point(335, 267);
            this.Khat6.Name = "Khat6";
            this.Khat6.Size = new System.Drawing.Size(31, 154);
            this.Khat6.TabIndex = 5;
            this.Khat6.TabStop = false;
            // 
            // MenuMain
            // 
            this.MenuMain.BackColor = System.Drawing.Color.Crimson;
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(401, 24);
            this.MenuMain.TabIndex = 9;
            this.MenuMain.Text = "Menu";
            this.MenuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuMain_ItemClicked);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.startToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Crimson;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Score.ForeColor = System.Drawing.Color.Black;
            this.Score.Location = new System.Drawing.Point(67, 2);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(77, 20);
            this.Score.TabIndex = 12;
            this.Score.Text = "Score : 0";
            // 
            // EnemyBox
            // 
            this.EnemyBox.BackColor = System.Drawing.Color.Transparent;
            this.EnemyBox.BackgroundImage = global::Driver2048.Properties.Resources.red_top_car_png_2;
            this.EnemyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnemyBox.Location = new System.Drawing.Point(236, 50);
            this.EnemyBox.Name = "EnemyBox";
            this.EnemyBox.Size = new System.Drawing.Size(100, 186);
            this.EnemyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnemyBox.TabIndex = 11;
            this.EnemyBox.TabStop = false;
            this.EnemyBox.Visible = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.RoyalBlue;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player.Image = global::Driver2048.Properties.Resources.car_top_view;
            this.Player.Location = new System.Drawing.Point(89, 317);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(73, 148);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 13;
            this.Player.TabStop = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Driver2048
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 526);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.EnemyBox);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.MenuMain);
            this.Controls.Add(this.Khat6);
            this.Controls.Add(this.Khat5);
            this.Controls.Add(this.Khat4);
            this.Controls.Add(this.Khat2);
            this.Controls.Add(this.Khat1);
            this.Controls.Add(this.Khat3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuMain;
            this.Name = "Driver2048";
            this.Text = "Driver2048";
            this.Load += new System.EventHandler(this.Driver2048_Load);
            this.SizeChanged += new System.EventHandler(this.Driver2048_SizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Driver2048_KeyUp);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Enemy;
        private System.Windows.Forms.GroupBox Khat1;
        private System.Windows.Forms.GroupBox Khat2;
        private System.Windows.Forms.GroupBox Khat3;
        private System.Windows.Forms.GroupBox Khat5;
        private System.Windows.Forms.GroupBox Khat6;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.PictureBox EnemyBox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.GroupBox Khat4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

