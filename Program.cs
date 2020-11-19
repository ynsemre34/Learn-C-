using System;

namespace Algoritma_Ders_Pratik
{
    class Program
    {
        static void Main(string[] args)
        {

            int value, pozitif = 0, limit = 100, negatif = 0, sıfır = 0;


            for (int counter = 0; counter < limit; counter++)
            {

                Console.WriteLine("Değerleri giriniz");
                value = Convert.ToInt32(Console.ReadLine());

                if (value == 0)
                {
                    sıfır++;

                }
                else if (value > 0)
                {
                    pozitif++;

                }
                else
                {
                    negatif++;

                }

            }


            Console.WriteLine("Sonuç");
            Console.WriteLine("Girilen değerler arasında " + sıfır + " tane sıfır değer vardır.");
            Console.WriteLine("Girilen değerler arasında " + pozitif + " tane pozitif değer vardır.");
            Console.WriteLine("Girilen değerler arasında " + negatif + " tane negatif değer vardır.");



        }
    }
}
