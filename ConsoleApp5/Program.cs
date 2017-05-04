using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geliri daxil edin");
            int gelirGun = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Gunlerin sayini daxil edin");
            int sayGun = Convert.ToUInt16(Console.ReadLine());
            int result = gelirGun * sayGun;
            double faiz;
            if (result > 1000)
            {
                faiz = result * 0.18;
            }
            else {
                faiz = result * 0.04;
            }
            double gelirNet = result - faiz;
            Console.WriteLine("Faizi = "+faiz);
            Console.WriteLine("NET Gelir = "+gelirNet + "AZN");
            Console.ReadLine();
     
        }
    }
}