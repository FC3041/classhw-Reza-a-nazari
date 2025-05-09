using System;

namespace S9con
{
    public class Student
    {
        private string name;
        private int stdid;
        private int natid;
        private int credit;
        private bool active;

        // سازنده کلاس Student
        public Student(string name, int stdid, int natid, int credit, bool active)
        {
            this.name = name;
            this.stdid = stdid;
            this.natid = natid;
            this.credit = credit;
            this.active = active;
        }

        public static Student Parse(string str)
        {
            string[] tokens = str.Split(',');
            var name = tokens[0];
            var stdid = int.Parse(tokens[1]);
            var natid = int.Parse(tokens[2]);
            var credit = int.Parse(tokens[3]);
            var active = bool.Parse( tokens[4]);
            return new Student(name,stdid , natid , credit, active) ;
        } 

        // متد ToString برای نمایش اطلاعات شیء
        public override string ToString()
        {
            return $"{name},{stdid},{natid},{credit},{active}";
        }
    }
}