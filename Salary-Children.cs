using System;

namespace Denemeler
{
    class Program
    {
        static void Main(string[] args)
        {

            int salary, resultsalary, children;
            Console.WriteLine("Maaşınızı Girin");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çocuk sayısını Girin.");
            children = Convert.ToInt32(Console.ReadLine());

            
            switch (children)
            {
                case 1:
                    resultsalary =(salary * 105)/100;
                    Console.WriteLine("Tebrikler %5 Bonus Kazandınız. Yeni maaşınız :" + resultsalary);
                    break;

                case 2:
                    resultsalary = (salary * 110)/100;
                    Console.WriteLine("Tebrikler %10 Bonus Kazandınız. Yeni maaşınız: " + resultsalary);
                    break;
                case 3:
                    resultsalary = (salary * 115)/100;
                    Console.WriteLine("Tebrikler %15 Bonus Kazandınız. Yeni maaşınız: " + resultsalary);
                    break;
                case 4:
                    resultsalary = (salary * 120)/100;
                    Console.WriteLine("Tebrikler %20 Bonus Kazandınız. Yeni maaşınız: " + resultsalary);
                    break;

                default:
                    resultsalary = (salary * 125) / 100;
                    Console.WriteLine("Tebrikler % 25Bonus Kazandınız.Yeni maaşınız: " +resultsalary);
                    break;
            }


        }
    }
}
