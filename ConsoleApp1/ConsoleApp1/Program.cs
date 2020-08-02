using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    abstract class Quadrilateral
    {
        public abstract int Area(int length);
    }
    class Square : Quadrilateral
    {
    
        public override int Area(int length)
        {
            return length * length;
        }
    }
    class Rectangle : Quadrilateral
    {
        int breath;
        public Rectangle(int _breath)
        {
            breath = _breath;
        }
       
        public override int Area(int length)
        {
            return length * breath;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(6);

            Console.WriteLine(r.Area(5));

            Square s = new Square();
            Console.WriteLine(s.Area(4));
            if (r.Area(5) > s.Area(4))
            {
                Console.WriteLine("square area is greater than rectangle area");
            }
            Console.Read();
        }
    }
}
