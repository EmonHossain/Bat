using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        Player player;
        Rectangle rect;
        Bat bat;
        Timer timer;

        public Form1()
        {
            InitializeComponent();
            //pictureBox1.BackColor = Color.Transparent;
            player = new Player(PlayerPictureBox,progressBar1);
            bat = new Bat(BatPictureBox);
            
            rect = new Rectangle(75, 56, 380, 139);
            progressBar1.Value = 100;

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            bat.move(player);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.move(Direction.RIGHT,rect);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.move(Direction.LEFT,rect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.move(Direction.UP,rect);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.move(Direction.DOWN,rect);
        }
    }
}
