using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_zest_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Area of the square: " + rectangle.Area(5));
            Console.WriteLine("Area of the rectangle: " + rectangle.Area(5, 2));
            Console.ReadKey();
        }
    }
    interface IFigure
    {
        int Area(int a);
        int Area(int a, int b);
    }
    class Rectangle : IFigure
    {
        public int Area(int a)
        {
            return a * a;
        }
        public int Area(int a, int b)
        {
            return a * b;
        }
    }
}
