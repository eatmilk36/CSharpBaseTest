using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateTest
{
    public class PredicateTest
    {
        public PredicateTest()
        {
            Point[] points = { new Point(100, 200),
                         new Point(150, 250), new Point(250, 375),
                         new Point(275, 395), new Point(295, 450) };

            // 定義 Predicate<T> delegate.
            Predicate<Point> predicate = FindPoints;

            // 尋找第一個點 X * Y 大於 100000
            Point first = Array.Find(points, predicate);

            // 輸出第一點大於 100000
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);

            //============================================下面是Landam

            // 尋找第一個點 X * Y 大於 100000
            Point first2 = Array.Find(points, x => x.X * x.Y > 100000);

            // 輸出第一點大於 100000
            Console.WriteLine("Found: X = {0}, Y = {1}", first2.X, first2.Y);
        }

        private bool FindPoints(Point obj)
        {
            return obj.X * obj.Y > 100000;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
