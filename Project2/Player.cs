using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace Project2
{
    class Player
    {
        private int moveRate;
        public PictureBox pic;
        public ProgressBar life;
        
        public Player(PictureBox pic,ProgressBar life)
        {
            this.pic = pic;
            moveRate = 20;
            this.life = life;
            life.Value = 100;
        }
        public void move(Direction d,Rectangle rect)
        {
            //Point tmp;
            switch (d)
            {
                case Direction.LEFT:
                    if(rect.Left<pic.Location.X)
                        pic.Location = new Point(pic.Location.X - moveRate, pic.Location.Y);
                    break;
                case Direction.RIGHT:
                    if (rect.Right > pic.Location.X)
                    pic.Location = new Point(pic.Location.X + moveRate, pic.Location.Y);
                    break;
                case Direction.UP:
                    if (rect.Top < pic.Location.Y)
                        pic.Location = new Point(pic.Location.X, pic.Location.Y - moveRate);
                    break;
                case Direction.DOWN:
                    if (rect.Bottom > pic.Location.Y)
                        pic.Location = new Point(pic.Location.X, pic.Location.Y + moveRate);
                    break;
            }
        }

    }
}
