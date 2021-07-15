using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1Ex1
{
    struct Point
    {
        private decimal y;
        public decimal _xCoordinate { get; set; }
        public decimal _yCoordinate
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

    }
}
