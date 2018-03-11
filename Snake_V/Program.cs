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
            Point p1 = new Point(2,5,'^');
            //p1.draw();
            Point p2 = new Point(4,2,'$');
            //p2.draw();
            Point p3 = new Point(10, 15, '@');
            Point p4 = new Point(22, 26, '!');

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            
            //numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2); 
            pList.Add(p3);
            pList.Add(p4);
            for (int i = 0; i < pList.Count+1; i++)
            {
                pList[i].draw();
            }

			Console.ReadLine();
		}
    }
}
