using System;

namespace part8
{
    public class Program
    {
        public static void Main()
        {
            double number;
            int count = 0;
            double sum = 0;
            double min = Double.MaxValue;
            double max = Double.MinValue;

            while (true)
            {
                Console.WriteLine("Adad ra vared konid (ya -1 baraye stop): ");
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    if (number == -1)
                    {
                        break;
                    }

                    count++;
                    sum += number;

                    if (number < min)
                    {
                        min = number;
                    }

                    if (number > max)
                    {
                        max = number;
                    }
                }
                else
                {
                    Console.WriteLine("Lotfan yek adad sahih vared konid.");
                }
            }

            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine("Tedad varediha: " + count);
                Console.WriteLine("miangiin: " + average.ToString("0.00"));
                Console.WriteLine("Kamtarin: " + min.ToString("0.00"));
                Console.WriteLine("bishtarin: " + max.ToString("0.00"));
            }
            else
            {
                Console.WriteLine("Hich adadi vared nashode.");
            }
        }
    }
}
