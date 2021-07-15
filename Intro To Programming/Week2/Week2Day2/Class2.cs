using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo1
{
    abstract class PersonNew
    {
        public abstract void Dowork();
        public void NormalFunction()
        {

        }
        public virtual void VirtualFunction()
        {

        }
           


    }
    class Employee:PersonNew
    {
        public int Eid { get; set; }
        public string  EmployeeName { get; set; }
        public string Designation { get; set; }
        public decimal BaseSalary { get; set; }
        public override void Dowork()
        {
            //logic
            //throw new NotImplementedException();
        }
        public virtual decimal CalculateSalary()
        {
            return this.BaseSalary;
        }
        public virtual void VirtualFunction()
        { }

    }
    class FulltimeEmployee:Employee
    {
        public decimal Benefits  { get; set; }
        public override decimal CalculateSalary()
        {
            
            return base.CalculateSalary() + Benefits;
        }
        

    }
    class PartimeEmployee:Employee
    { 
        
    }



}
