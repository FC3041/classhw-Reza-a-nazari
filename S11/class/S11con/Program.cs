using System;
using System.Collections.Generic;

namespace S11con
{
    class Program
    {
        static void Main(string[] args)
        {
         //         // ایجاد چند دانشجو
         //         Student s1 = new Student(fname: "Zari", lname: "Mousavi", id: 34345, stdid: 403521123, GPA: 18.5);
         //         Student s2 = new Student(fname: "Ali", lname: "Rezaei", id: 34346, stdid: 403521124, GPA: 17.25);
         //         Student s3 = new Student(fname: "Sara", lname: "Ahmadi", id: 34347, stdid: 403521125, GPA: 19.0);

         //         // ایجاد لیستی از دانشجویان
         //         List<Student> students = new List<Student>
         //         {
         //             s1,
         //             s2,
         //             s3
         //         };

         //         // نمایش اطلاعات دانشجویان
         //         Console.WriteLine("List of Students:");
         //         foreach (var student in students)
         //         {
         //             Console.WriteLine($"Full Name: {student.Fullname}, ID: {student.id}, Student ID: {student.stdid}, GPA: {student.GPA}");
         //         }

         //         // محاسبه میانگین GPA دانشجویان
         //         double averageGPA = students.Average(s => s.GPA);
         //         Console.WriteLine($"\nAverage GPA of all students: {averageGPA:F2}");
         //     }
         int sum =0 ;
         int loopcount =0 ;
         while(true)
         {
            try
            {
                loopcount ++ ;
                int n = int.Parse(Console.ReadLine());
                sum+=n;
                System.Console.WriteLine($"you entered {n}");
                System.Console.WriteLine($"sum divide by n is {sum/n}");
                
            }
            catch(Exception e)
            {
                System.Console.WriteLine($"error . try again {e.Message}");
            }
            // catch(DivideByZeroException)
            // {
            //     System.Console.WriteLine("you entered zero for divison 1 will be used instead");
            //     System.Console.WriteLine($"sum divided by n is {sum/1}");
            //     continue ;
            // }
            finally
            {
                System.Console.WriteLine(loopcount);
            }
         }
        }
    }
}