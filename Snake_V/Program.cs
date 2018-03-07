using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_V
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym='*';
            p1.draw();
            Point p2 = new Point();
            p2.x = 5;
            p2.y = 9;
            p2.sym = '&';
            p2.draw();
           // Draw(p2.x, p2.y, p2.sym);
            /* int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            Draw(x1, y1, sym1);
            */

            Console.ReadLine();
        }
    }
}
