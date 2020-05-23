using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Balls
{
    class Ball
    {
        public int x, y;
        public int Speed { get; private set; }
        public double Direction { get; set; }
        public Color Color { get; private set; }
        int radius = 10;

        public Ball (int speed, double direction, Color color, int x, int y)
        {
            Speed = speed;
            Direction = direction;
            Color = color;
            this.x = x;
            this.y = y;
        }

    //    public void Move(Rectangle area)
    //    {
    //        while(true)
    //        {
    //            MakeStep(area);
    //        }
    //    }
    //    public void MakeStep(Rectangle area)
    //    {
    //        int possibleX = (int)(x + 2*Math.Cos(Direction)),
    //            possibleY = (int)(y + 2*Math.Sin(Direction));
    //        bool check = CheckIntersect(possibleX, possibleY, area);
            

    //        x = check ? (int)(x + 2 * Math.Cos(Direction)) : possibleX;
    //        y = check ? (int)(y + 2 * Math.Sin(Direction)) : possibleY;
    //    }
    //    private bool CheckIntersect(int x, int y, Rectangle area)
    //    {
    //        if(x <= area.X || x + 2*radius >= area.X + area.Width)
    //        {
    //            Direction = Direction > 0 ? Math.PI - Direction : -Math.PI-Direction;
    //            return true;
    //        }
    //        if(y <= area.Y || y + 2*radius >= area.Y + area.Height)
    //        {
    //            Direction = -Direction;
    //            return true;
    //        }
    //        return false;
    //    }
    }
}
