using System;

namespace ForLoopBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            int TekToplam = 0;
            int CiftToplam = 0;


            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    TekToplam += i;
                else
                    CiftToplam += i;
            }
            Console.WriteLine("Tek Toplam: " + TekToplam);
            Console.WriteLine("Çift Toplam:" + CiftToplam);
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break; //Döngüyü sonlandırır.
                Console.WriteLine(i);

            }
        }


    }

}
