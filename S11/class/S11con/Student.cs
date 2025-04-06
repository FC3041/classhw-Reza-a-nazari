using System;

namespace S11con
{
    internal class Student
    {
        // Fields
        public string fname;
        public string lname
        {
            get => lname ;
            set => lname = value ;
        }

        // Properties
        public int id { get; set; }
        public int stdid { get; set; }
        public double GPA { get; private set; } // فقط قابل خواندن از بیرون

        // Computed Property
        public string Fullname => $"{fname} {lname}";

        // Constructor
        public Student(string fname, string lname, int id, int stdid, double GPA)
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
            this.stdid = stdid;

            // اعتبارسنجی GPA
            if (GPA < 0 || GPA > 20)
            {
                throw new ArgumentException("GPA must be between 0 and 20.");
            }
            this.GPA = GPA;
        }
    }
}