using System;
namespace Week2Day1Ex2
{
    class Student
    {
        private int Studentid;
        private string StudentFname;
        private string StudentLname;
        public char _Grade { get; set; }

        public int _Studentid
        { 
            get { return this.Studentid; }
            set { this.Studentid = value; }
        }
       public string _StudenFname
        {
            get { return this.StudentFname; }
            set { this.StudentFname = value; }
        }
        public string _StudentLname
        {
            get { return this.StudentLname; }
            set { this.StudentLname = value; }
        }

        public Student()
        { }
    }
}
