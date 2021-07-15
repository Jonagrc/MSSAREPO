using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Ex1
{
    abstract class Shape
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _description { get; set; }
        public abstract decimal calArea();

        public Shape()
        {
        }
    }
    class Circle : Shape
    {
        public decimal _raduis { get; set; }

        public override decimal calArea()
        {
            return Convert.ToDecimal(Math.PI) * (_raduis * _raduis);
        }

    }
    class Square : Shape
    {
        public decimal side { get; set; }
        public override decimal calArea()
        {
            return side * side;
        }
    }
}
