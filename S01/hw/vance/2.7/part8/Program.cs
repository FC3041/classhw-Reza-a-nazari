using System;

namespace part8
{
    public class Program
    {
        public static bool sal_kabiseh_ast(int sal)
        {
            return (sal % 4 == 0 && sal % 100 != 0) || (sal % 400 == 0);
        }

        public static int tedad_rooz_haye_mah(int sal, int shomare_mah)
        {
            int[] roozha = {31,28,31,30,31,30,31,31,30,31,30,31};
            if (shomare_mah ==2 && sal_kabiseh_ast(sal))
            {
                return 29;
            }
            if (shomare_mah >=1 && shomare_mah <= 12)
            {
                return roozha[shomare_mah - 1];
            }
            else
            {
                return -1;
            }
        }

        public static int rooz_haye_ghabl_az_tarikh(int sal,int shomare_mah,int rooz)
        {
            int roozha=0;
            for (int mah =1; mah < shomare_mah; mah++)
            {
                roozha += tedad_rooz_haye_mah(sal, mah);
            }
            roozha+=rooz-1;
            return roozha;
        }

        public static void Main()
        {
            Console.Write("Yek sal vared konid: ");
            int sal = int.Parse(Console.ReadLine());

            Console.Write("Shomare mah ra vared konid (1=Farvardin, 12=Esfand): ");
            int shomare_mah = int.Parse(Console.ReadLine());

            Console.Write("Shomare rooz ra vared konid: ");
            int rooz=int.Parse(Console.ReadLine());

            int roozha = rooz_haye_ghabl_az_tarikh(sal, shomare_mah, rooz);

            Console.WriteLine("Tedad rooz haye ghabl az tarikh " + sal + "-" + shomare_mah + "-" + rooz + " barabar ast ba " + roozha);
        }
    }
}