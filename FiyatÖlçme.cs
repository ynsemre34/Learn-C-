using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritma_Ders_Pratik
{
    class Program_v2
    {
        static void Main(string[] args)
        {

            int a101_fiyat, bim_fiyat, a101_pahalı = 0, bim_pahalı = 0, EnBüyükFark;
            List<int> fiyatlistesi = new List<int>();
            

            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Ürünün Bim'deki fiyatını giriniz");
                bim_fiyat = Convert.ToInt32(Console.ReadLine());

                fiyatlistesi.Add(bim_fiyat);

                Console.WriteLine("Ürünün A-101'deki fiyatını giriniz");
                a101_fiyat = Convert.ToInt32(Console.ReadLine());

                fiyatlistesi.Add(a101_fiyat);

                if (bim_fiyat < a101_fiyat)
                {
                    a101_pahalı++;

                }
                else
                {
                    bim_pahalı++;
                }

            }

            EnBüyükFark = (fiyatlistesi.Max()) - (fiyatlistesi.Min());

            Console.WriteLine("A-101'de pahalı ürün sayısı = " + a101_pahalı);
            Console.WriteLine("Bim'de pahalı ürün sayısı = " + bim_pahalı);
            Console.WriteLine("En Büyük Fark = " + EnBüyükFark);
            

        }
    }
}
