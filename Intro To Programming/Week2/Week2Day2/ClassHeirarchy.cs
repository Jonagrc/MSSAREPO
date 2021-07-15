using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo1
{
    struct Address
    {
        public int _HouseNumber
        {
            get; set;
        }
        public string  StreetName { get; set; }
        public string  State { get; set; }
        public int ZipCode { get; set; }
    }
    
    
    class Person
    {
        private int age;
        private string firstname;
        private string lastname;
        private Address address;
        public Address _Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }

        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstname; ;
            }
            set
            {
                this.firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastname; 
            }
            set
            {
                this.lastname = value;
            }
        }
        public string Haircolor { get;
            set;
          
        }
        public void DoWork()
        { 
        }
        private void PrivateFunction()
        {
            // only available in this class
        }
        protected void ProtectedFunction()
        {

        }


    }

    class Test
    { }
    //multiple inheritance  not allowed , multilevel possible
    class Student:Person
    {
      public string SchoolName { get; set; }
      public char Grade { get; set; }

        public void SetGrades()
        {
            base.ProtectedFunction();
            //logic
        }



    }
    class K12:Student
    {
        public void Test()
        {
            
        }
    }
    class Graduate:Student
    {

    }
    class Instructor:Person
    { 

    }

}
