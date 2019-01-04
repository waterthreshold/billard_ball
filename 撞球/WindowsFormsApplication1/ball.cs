using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class ball
    {
        int r = 5;
        int r2 = 10;
        public int x, y;
        public  SolidBrush b;
        int no;

        public ball(int a)
        {
            no = a;
        }
        public void Draw(Graphics g)
        {
            g.FillEllipse(b,x-r,y-r,r2,r2);
        }
    }
}
