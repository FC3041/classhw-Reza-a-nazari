using System;

namespace S9con
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            // ایجاد شیء از کلاس Student
            Student s = new Student(
                name: "reza",
                stdid: 403521,
                natid: 98765,
                credit: 17,
                active: true);

            // چاپ اطلاعات شیء Student
            Console.WriteLine(s);
        }
    }
}