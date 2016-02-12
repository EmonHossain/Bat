using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Project2
{
    class Enemy
    {
        public ProgressBar life;
        public PictureBox enemy;
        private int enemyMoveRate;

        public Enemy(PictureBox enemy,ProgressBar life)
        {
            this.enemy = enemy;
            this.life = life;
            enemyMoveRate = 10;
        }

        public void Attack(Player p)
        {
            if ((Math.Abs(p.pic.Location.X - enemy.Location.X) < 20) && (Math.Abs(p.pic.Location.Y - enemy.Location.Y) < 20))
            {
                if (p.life.Value - 10 >= 0)
                    p.life.Value -= 10;
                else
                    MessageBox.Show("You are done");
            }
        }

    }
}
