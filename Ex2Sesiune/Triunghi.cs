using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Sesiune
{
    public class Triunghi
    {
        public Triunghi(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Point A { get; set; } = new Point(0, 0);
        public Point B { get; set; } = new Point(0, 0);
        public Point C { get; set; } = new Point(0, 0);
    }
}
