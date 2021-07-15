using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            Student newstudent = new Student();
            Employee emp = new Employee();
            FulltimeEmployee fulltimeEmployee = new FulltimeEmployee();
            Employee empnew = new FulltimeEmployee();
            Maths objmath = new Maths();
            

            
            var card = "00323-dfdf-242";
            try
            {
                //logic
                if (card.Length > 10)
                {
                    throw new InvalidCardException();
                }
            }
            catch(Exception ex)
            {
                //llog
                Console.WriteLine(ex.Message);
            }


        }
        static int Add(int i, int j)
        {
            return i + j;
        }
        static int Add(int i, int j, int k)
        {
            return i + j + k;
        }

    }
}
