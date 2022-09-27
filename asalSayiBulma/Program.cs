using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalSayiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.Write("Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0 || sayi == 1)
            {
                Console.WriteLine("Girilen sayı asal değildir.");
            }
            else
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac++;

                    }
                }
                if (sayac == 0)
                {
                    Console.WriteLine("{0} sayısı asal sayıdır.", sayi);
                }
                else
                {
                    Console.WriteLine("{0} sayısı asal sayı değildir.", sayi);
                }
                
            }
            Console.ReadLine();
        }


        
    }
}
