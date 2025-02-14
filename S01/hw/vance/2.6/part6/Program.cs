using System;

namespace part6
{
    public class Program
    {
        public static void mohasebe(int amount)
        {
            int quarters = amount / 25;
            amount %= 25;
            int dimes = amount / 10;
            amount %= 10;
            int nickels = amount / 5;
            amount %= 5;
            int pennies = amount;

            Console.WriteLine($"The change from a dollar for {quarters * 25 + dimes * 10 + nickels * 5 + pennies} cents is:");
            Console.WriteLine($"{quarters} quarters");
            Console.WriteLine($"{dimes} dimes");
            Console.WriteLine($"{nickels} nickels");
            Console.WriteLine($"{pennies} pennies");
        }

        public static void Main()
        {
            Console.Write("Enter an amount kamtar az 100 cents: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount >= 0 && amount < 100)
            {
                mohasebe(amount);
            }
            else
            {
                Console.WriteLine("Khata");
            }
        }
    }
}
