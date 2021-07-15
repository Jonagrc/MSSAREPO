using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            Circle Circle1 = new Circle();
            Square square1 = new Square();
            while (choice == 'y' || choice == 'Y')
            {
                Console.WriteLine("Hello which would you like to calculate the area for ?");
                Console.WriteLine("Press 1. for Circle");
                Console.WriteLine("Press 2. for Square");
                int pickOne = Convert.ToInt32(Console.ReadLine());

                switch (pickOne)
                {

                    case 1:
                        Console.WriteLine("Please enter the ID of the circle");
                        Circle1._id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the description of the circle");
                        Circle1._description = Console.ReadLine();
                        Console.WriteLine("Please enter the raduis of the circle");
                        Circle1._raduis = Convert.ToInt32(Console.ReadLine());
                        Circle1.calArea();
                        Console.ReadLine();
                        Console.WriteLine("Area of the circle is : {0}", Circle1.calArea());
                        break;
                    case 2:
                        Console.WriteLine("Please enter the ID of the square");
                        square1._id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the description of the square");
                        square1._description = Console.ReadLine();
                        Console.WriteLine("Please enter the length of the sides of the square");
                        square1.side = Convert.ToInt32(Console.ReadLine());
                        square1.calArea();
                        Console.WriteLine("Area of the square is : {0}", square1.calArea());
                        Console.ReadLine();
                        break;

                }
                Console.WriteLine("Would You like to try again? y or n ");
                choice = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
