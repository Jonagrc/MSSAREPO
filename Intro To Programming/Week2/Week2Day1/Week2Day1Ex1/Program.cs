using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a coordinate X first then Y");
            Point p1 = new Point();
            p1._xCoordinate = Convert.ToDecimal(Console.ReadLine());
            p1._yCoordinate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter a second coordinate X first then Y");
            Point p2 = new Point();
            p2._xCoordinate = Convert.ToDecimal(Console.ReadLine());
            p2._yCoordinate = Convert.ToDecimal(Console.ReadLine());
            checkPoint(p1, p2);
            Console.ReadLine();

        }
        static void checkPoint(Point p1, Point p2)
        {
            if (p2._xCoordinate <= p1._xCoordinate)
            {
                Console.WriteLine(p2._xCoordinate + " is on the left side of " + p1._xCoordinate);
            }
            else 
            {
                Console.WriteLine(p1._xCoordinate + " is on the left side of " + p2._xCoordinate);
            }

        }
    }
}
