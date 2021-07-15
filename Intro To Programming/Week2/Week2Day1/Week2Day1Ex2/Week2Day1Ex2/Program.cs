using System;

namespace Week2Day1Ex2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student newstu1 = new Student();

            Console.WriteLine("Hello lets enter a students information in your class");
            
            Console.WriteLine("Enter Student first name ");
            newstu1._StudenFname = Console.ReadLine();
            Console.WriteLine("Enter Student Last name ");
            newstu1._StudentLname = Console.ReadLine();
            Console.WriteLine("Enter Student ID number ");
            newstu1._Studentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Letter grade ");
            newstu1._Grade = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("First student is {0} {1} , with a grade of {2} and student id of : {3}",
                newstu1._StudenFname, newstu1._StudentLname, newstu1._Grade, newstu1._Studentid);
            

        }
    }
}
