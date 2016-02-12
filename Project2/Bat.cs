using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Project2
{
    class Bat
    {
        private PictureBox pic;
        private int life;
        private int moveRate;
        private Random rand;

        public Bat(PictureBox pic)
        {
            this.pic = pic;
            moveRate = 5;
            rand = new Random();
        }
        public void move(Player player)
        {
            if (rand.Next(100) < 40)
            {
                int x = 0, y = 0;
                if (player.pic.Location.X < pic.Location.X)
                    x = pic.Location.X - moveRate;
                else if (player.pic.Location.X > pic.Location.X)
                    x = pic.Location.X + moveRate;
                if (player.pic.Location.Y < pic.Location.Y)
                    y = pic.Location.Y - moveRate;
                else if (player.pic.Location.Y > pic.Location.Y)
                    y = pic.Location.Y + moveRate;
                pic.Location = new Point(x, y);
                Attack(player);
            }
        }
        public void Attack(Player p) 
        {
            if((Math.Abs(p.pic.Location.X - pic.Location.X) < 20) && (Math.Abs(p.pic.Location.Y - pic.Location.Y) < 20) )
            {
                if (p.life.Value - 10 >= 0)
                    p.life.Value -= 10;
                else
                    MessageBox.Show("You are done");
            }
        }
    }
}
