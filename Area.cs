using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectTest
{
    delegate double DArea(int d1, int d2);
    class Area
    {
        public static double TriA(int H, int B)
        { return (H * B) / 2; }

        public static double RecA(int L, int W)
        { return L * W; }

        public static void GetArea(int x, int y, DArea tv)
        {
            double area = tv(x, y);

            Console.WriteLine("高:{0},底:{1},面積:{2}\n", x, y, area);
        }
    }
}