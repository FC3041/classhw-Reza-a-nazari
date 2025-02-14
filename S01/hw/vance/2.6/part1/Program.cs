using System;

namespace do_bakhsh_shish
{
    public class Program
    {
        public static void Aya_lipyear_hast(int[] a, int size)
        {
            for (int i = 0; i < size; i++)
            {
                int year = a[i];
                if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
            }
        }

        public static void Main()
        {
            int[] years = { 2000, 2004, 2100, 2020, 2023, 2024 };
            int size = years.Length; // <===== یعنی تعداد آرایه‌ها

            Aya_lipyear_hast(years, size);
        }
    }
}
