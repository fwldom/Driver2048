using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Runtime.InteropServices;

namespace Driver2048
{
    public partial class Driver2048 : Form
    {
        public static int ene = -250;
        public static int ScoreNum = 0;
        public Driver2048()
        {
            InitializeComponent();
        }
        private void Tick()
        {

        }
        private void Enemy_Tick(object sender, EventArgs e)
        {
            ene++;
            if (EnemyBox.Visible == true)
            {
                Random RandEnemy = new Random();
                EnemyBox.Location = new Point(EnemyBox.Location.X, EnemyBox.Location.Y + (5 + (ScoreNum * 1)));
            }
            if (Khat1.Location.Y < 888)
            {
                Khat1.Location = new Point(Khat1.Location.X, Khat1.Location.Y + 8 + ScoreNum);
                Khat2.Location = new Point(Khat2.Location.X, Khat2.Location.Y + 8 + ScoreNum);
                Khat3.Location = new Point(Khat3.Location.X, Khat3.Location.Y + 8 + ScoreNum);
                Khat4.Location = new Point(Khat4.Location.X, Khat4.Location.Y + 8 + ScoreNum);
                Khat5.Location = new Point(Khat5.Location.X, Khat5.Location.Y + 8 + ScoreNum);
                Khat6.Location = new Point(Khat6.Location.X, Khat6.Location.Y + 8 + ScoreNum);

            }
            else
            {
                Khat1.Location = new Point(Khat1.Location.X, Khat1.Location.Y - 1250);
                Khat2.Location = new Point(Khat2.Location.X, Khat2.Location.Y - 1250);
                Khat3.Location = new Point(Khat3.Location.X, Khat3.Location.Y - 1250);
                Khat4.Location = new Point(Khat4.Location.X, Khat4.Location.Y - 1250);
                Khat5.Location = new Point(Khat5.Location.X, Khat5.Location.Y - 1250);
                Khat6.Location = new Point(Khat6.Location.X, Khat6.Location.Y - 1250);
            }
            if (ene >= 100)
            {
                ScoreNum++;
                EnemyBox.Visible = true;
                Random RandEnemy = new Random();
                EnemyBox.Location = new Point(RandEnemy.Next(50, this.Width - 50), -550);
                ene = -150;
                int car = RandEnemy.Next(0, 7);
                if (car == 0)
                {
                    EnemyBox.BackgroundImage = Properties.Resources.R1;
                }
                if (car == 1)
                {
                    EnemyBox.BackgroundImage = Properties.Resources.R__1_;
                }
                if (car == 2)
                {
                    EnemyBox.BackgroundImage = Properties.Resources.R__2_;
                }
                if (car == 3)
                {
                    EnemyBox.BackgroundImage = Properties.Resources.red_top_car_png_2;
                }
                if (car == 4)
                {
                    EnemyBox.BackgroundImage = Properties.Resources.white_car_parking_meter_top_png_18;
                }
                if (car == 5)
                {
                    EnemyBox.BackgroundImage = Properties.Resources.y6HviX;
                }
                if (car == 6)
                {
                    EnemyBox.BackgroundImage = Properties.Resources.yellow_top_car_png_7;
                }
                Score.Text = "Score : " + ScoreNum + "";
            }
            Rectangle rectplayer = new Rectangle(Player.Location.X, Player.Location.Y, Player.Width, Player.Height);
            Rectangle rectenemy = new Rectangle(EnemyBox.Location.X, EnemyBox.Location.Y, EnemyBox.Width, EnemyBox.Height);
            if (rectenemy.IntersectsWith(rectplayer))
            {
                Enemy.Enabled = false;
                SystemSounds.Beep.Play();
                MessageBox.Show("Game Over !!!");
                Score.Text = "Game Over!! Restart From Menu/Game";
            }
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // width of ellipse
                int nHeightEllipse // height of ellipse
        );
        private void Driver2048_Load(object sender, EventArgs e)
        {
            Enemy.Enabled = true;
            Random RandEnemy = new Random();
            EnemyBox.Location = new Point(RandEnemy.Next(50, this.Width - 50), -750);
            Player.BackColor = Color.Transparent;
            Player.BackColor = Color.Transparent;
            Player.Parent = this;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void Driver2048_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Player.Location.X > 50)
                {
                    Point LocPlayer = new Point(Player.Location.X - 45, Player.Location.Y);
                    Player.Location = LocPlayer;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (Player.Location.X < this.Width - 100)
                {
                    Point LocPlayer = new Point(Player.Location.X + 45, Player.Location.Y);
                    Player.Location = LocPlayer;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (Player.Location.Y > 50)
                {
                    Point LocPlayer = new Point(Player.Location.X, Player.Location.Y - 45);
                    Player.Location = LocPlayer;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (Player.Location.Y < 339)
                {
                    Point LocPlayer = new Point(Player.Location.X, Player.Location.Y + 45);
                    Player.Location = LocPlayer;
                }
            }
        }

        private void Driver2048_SizeChanged(object sender, EventArgs e)
        {
            Point LocPlayer = new Point(this.Width - 100, Player.Location.Y);
            Player.Location = LocPlayer;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Enemy.Enabled = true;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreNum = 0;
            ene = 0;
            Player.Location = new Point(250, 350);
            Random RandEnemy = new Random();
            EnemyBox.Location = new Point(RandEnemy.Next(50, this.Width - 50), -750);
            Enemy.Enabled = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enemy.Enabled = false;
            if (stopToolStripMenuItem.Text == "Play")
            {
                Score.Text = "Played";
                stopToolStripMenuItem.Text = "Stop";
                Enemy.Enabled = true;

            }
            else
            {
                stopToolStripMenuItem.Text = "Play";
                Score.Text = "Stoped";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
