using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace Lecturer4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //-----------------------Dizi Oluşturma Start-----------------------

            //Tanılama
            //Method 1 - (Kullanılmayan)
            string[] array_v1;

            //Method 2 
            string[] money = {"Dollar", "Euro", "TL", "Sterlin", "Ruble" };

            //Ekrana yazıdmra

            //Method 1
            Console.WriteLine(money[1]);

            //String.Join yöntemi ile dizi içerisinde bulunan her üye elemanı için ayırıcı kullanarak birleştirir.
            string srMoneyJoined = string.Join(" - ", money);

            // Method 2 Dizi normal şekilde belirtilen işaretle ayırılarak yazılır.(Güzel parantez yoktur!)
            Console.WriteLine($"Görüntülenme türü 1 =>  {srMoneyJoined}");

            // Dizi adını güzel parantez içinde yazdırır.
            Console.WriteLine($"Görüntülenme türü 2 => {{srMoneyJoined}}");

            // Diziyi güzel parantez içerisinde yazdırır.
            Console.WriteLine($"Görüntülenme türü 3 => {{{srMoneyJoined}}}");

            //Method 3 
            string srMoneyJoinedv2 = money[0]+ " $ " +money[1]+ " € " +money[2]+ " ₺ " +money[3]+ " £ "  +money[4]+ " P " ;
            Console.WriteLine(srMoneyJoinedv2);

            //Max ve Min değerleri yazdırma (Alfabetik sıra ile)
            Console.WriteLine("The Max value in money array = " + money.Max());
            Console.WriteLine("The Min value in money array = " + money.Min());

            //İnteger dizide Max ve Min değerleri yazdırma örneği
            int[] ex_numbers = { 15, 3, 10, 3, 53, 35 };

            Console.WriteLine(ex_numbers[2]);
            Console.WriteLine("The Max value in money array = " + ex_numbers.Max());
            Console.WriteLine("The Min value in money array = " + ex_numbers.Min());

            Console.Clear();

            //-----------------------Dizi Oluşturma End-----------------------

            //-----------------------Döngüler Start-----------------------


            // For döngüsü ile ekrana dizide kaç tane eleman olduğunu yazma yöntemi.
            string srMoneyJoinedv3 = "";

            for(int counter=0; counter< money.Length; counter++)
            {
                Console.WriteLine("for looping and currently counter = " + counter);
                srMoneyJoinedv3 += money[counter];

                if (counter < money.Length)
                {
                    srMoneyJoinedv3 = srMoneyJoinedv3 + " - ";
                }
            }

            // Foreach döngüsü ile dizi elemanlarını ekrana yazdırma

            foreach (string srMoney in money)
            {
                Console.WriteLine(srMoney + " ");

            }

            // Foreach döngüsü ile dizi elemanlarını ekrana yazdırma 
            string srMoneyJoinedv4 = "";

            foreach (string srMoneyv2 in money)
            {
                
                int counterv2 = 0; counterv2++;

                srMoneyJoinedv4 += srMoneyv2;
                Console.WriteLine("for looping and currently counter = " + srMoneyv2);
                if (counterv2 < money.Length)
                {
                    srMoneyJoinedv4 += " - ";
                }
            }

            Console.Clear();

            //-----------------------Döngüler END-----------------------

            // Karakter analizi
            string srName = "Mercedes-Benz";

            Console.WriteLine("Tanımlanan değerin kaç karaktere sahip olduğunu gösterir => " + srName.Length);
            Console.WriteLine("srName.Substring(0) =>" + srName.Substring(0));
            Console.WriteLine("srName.Substring(4) =>" + srName.Substring(4));
            Console.WriteLine("srName.Substring(2,9) => " + srName.Substring(2, 9));

            Console.Clear();

            //-----------------------Dizi Eleman Sayısı Belirleme Start---------------------

            // Bir dizinin eleman sayısına belirleme
            string[] car = new string[4] { "Bmw", "Audi", "Mercedes-Benz", "Volvo" };
            Console.WriteLine("Belirlenen dizi elemanı (String)=> :" + car[0]);

            //Bir üsteki örnekle aynı mantıkla çalışır tek farkı integer olması
            int[] irArray5 = new int[3] { 3, 4, 5 };
            Console.WriteLine("Belirlenen dizi elemanı (İnteger)=> :" + irArray5[0]);

            Console.Clear();


            //-----------------------Dizi Eleman Sayısı Belirleme END-----------------------

            //-----------------------İnteger ve Boolean Diziler Start-----------------------

            // Hata kontrolcüsü //Değişken tanımlanır fakat elemanlar belirlenmediği zaman elemanlar null değerine sahip olur.

            int[] irArrayNull;

            // İnteger dizide belirlenen eleman sayısında tanımlama yapılmamış ise tüm değerlere 0 atanır.
            int[] irArray6 = new int[5];
            Console.WriteLine("default value of int array is :" + irArray6[0]);

            // Aynı şekilde char dizide de geçerlidir fakat 0 yerine konsolda bir şey yazmaz ('\0')
            char[] charArray = new char[10];
            Console.WriteLine("default value of char array is :" + charArray[0]);

            //Örnek bir char dizisi belirleme
            charArray[5] = 'F';
            Console.WriteLine("the sixth character of the char array = " + charArray[5]);

            //İnteger Bir dizide tanımlama, eleman sayısı öğrenme, yazdırma ve max-min değerlerini yazdırma.
            
            //Tanımlama
            int[] myNumberGrup = { 05, 53, 377, 70, 19 };

            //Eleman sayısı öğrenme
            Console.WriteLine("Dizideki eleman sayısı = " + myNumberGrup.Length);
            
            //Yazdırma
            Console.WriteLine("Dizinin 4'üncü elemanı => " + myNumberGrup[3]);

            //Max ve Min değerlerini yazdırma
            Console.WriteLine("Dizinin Max değeri => " + myNumberGrup.Max());
            Console.WriteLine("Dizinin Min değeri => " + myNumberGrup.Min());

            Console.Clear();

            //-----------------------İnteger ve Boolean Diziler END-----------------------





            //-----------------------Random Generator Method START------------------------------

            //Random dizi elemanı üretme
            Random myRandomGen = new Random();
            int irRandomArray = myRandomGen.Next(10000000);
            Console.WriteLine("Rastgele sayılar = " + irRandomArray.ToString("N0"));

            //Eleman sayısı belirlenen integer diziyi ekrana yazdırma (Tanımlama yapılmadan önce!)
            // Environment.NewLine (\r\n) ile aynı işlevdedir.  ( n= Yeni satır) (r = Satırbaşı)

            int[] myHundredElementsArray = new int[25];
            string srPrintArray = string.Join("\t", myHundredElementsArray);
            Console.WriteLine("Rastgele sayıları atamadan önce :" + Environment.NewLine + srPrintArray);

            // For Döngüsü ile rastgele sayı üretme ve yazdırma
            Random myRandomGenerator = new Random();
            
            for(int Counterv4 = 0; Counterv4 < myHundredElementsArray.Length; Counterv4++)
            {
                myHundredElementsArray[Counterv4] = myRandomGenerator.Next(0, 10000);
            }
            srPrintArray = string.Join("\t", myHundredElementsArray);
            Console.WriteLine("myHundredElementsArray Binlik ayırıcı biçimlendirmesi olmadan rastgele sayılar atadıktan sonra:" + Environment.NewLine + srPrintArray);

            // Bir önceki For Döngüsü ile tek farkı binlik ayırıcıya sahip olması
            srPrintArray = "";

            for (int Counterv5 = 0; Counterv5 < myHundredElementsArray.Length; Counterv5++)
            {
                srPrintArray += myHundredElementsArray[Counterv5].ToString("N0");
                if(Counterv5 < myHundredElementsArray.Length)
                {
                srPrintArray += "\n";
                }
            }

            Console.WriteLine("myHundredElementsArray Binlik ayırıcı biçimlendirmesi varken rastgele sayılar atadıktan sonra:" + Environment.NewLine + srPrintArray);

            Console.Clear();

            //-----------------------Random Generator Method END------------------------------

            //-----------------------Sort, Reverse ve Copy Methodları Start------------------------------

            //Array.Sort Methodu 
            Array.Sort(myHundredElementsArray);

            // Aşağıdaki Olayın karşılığı buna eşittir => [LinQ: .Select(pr => pr.ToString("N0")));]
            srPrintArray = string.Join("\n", myHundredElementsArray.Select(pr => pr.ToString("N0")));

            Console.WriteLine("myHundredElementsArray artan şekilde sıraladıktan sonra :" + Environment.NewLine + srPrintArray);

            //Array.Reverse Methodu
            Array.Reverse(myHundredElementsArray);
            srPrintArray = string.Join("\n", myHundredElementsArray.Select(pr => pr.ToString("N0")));

            Console.WriteLine("myHundredElementsArray azalan şekilde sıraladıktan sonra :" + Environment.NewLine + srPrintArray);

            Console.Clear();
            //myHundredElemetsArray[100] = 23124; // Dizi 100 öğe olarak başlatıldığından bu işe yaramayacak
            //System.IndexOutOfRangeException: 'Dizin, dizinin sınırlarının dışındaydı.'


            //Array.Copy Methodu (26 yazmamızın nedeni aslında dizilerin 0'dan başladığı için orjinal değerin 25 olmasından kaynaklıdır.)
            int[] myHundredElementsArray2 = new int[26];
            myHundredElementsArray.CopyTo(myHundredElementsArray2, 0);

            myHundredElementsArray2[25] = 3123;

            Console.WriteLine("Dizi elemanı gösterme : " +myHundredElementsArray2[25]+ "  " + myHundredElementsArray2[23]+ "  " + myHundredElementsArray2[24]);
            
            Console.Clear();

            //-----------------------Sort, Reverse ve Copy Methodları END------------------------------
            
            //-----------------------İki Boyutlu Dizi Oluşturma Start----------------------------------

            // Tanımlama Method 1 [Satır, Sütun]   
            string[,] Array2D = new string[3, 5]; // 3 katlı ve her katda 5 daire vardır.

            Array2D[0, 2] = "Arman";
            Array2D[0, 3] = "Ahmet";
            Array2D[1, 2] = "Ali";
            Array2D[1, 4] = "Mehmet";
            Array2D[2, 1] = "Koray";
            Array2D[2, 3] = "Mustafa";
            Array2D[2, 4] = "Emre";

            Console.WriteLine(Array2D[0, 2]);
            Console.WriteLine(Array2D[0, 3]);
            Console.WriteLine(Array2D[1, 2]);
            Console.WriteLine(Array2D[1, 4]);
            Console.WriteLine(Array2D[2, 1]);
            Console.WriteLine(Array2D[2, 3]);
            Console.WriteLine(Array2D[2, 4]);

            Console.WriteLine("İçindeki tüm elemanların sayısı = " + Array2D.Length); // Eleman sayısı
            Console.WriteLine("Array2D.GetLength(0) = " + Array2D.GetLength(0)); // Satır
            Console.WriteLine("Array2D.GetLength(1) = " + Array2D.GetLength(1)); // Sütun

            // For Döngüsü 2 Boyutlu String Dizi elemanlarını yazdırma
            for (int Counter_v1 = 0; Counter_v1 < Array2D.GetLength(0); Counter_v1++)
            {
                for (int Counter_v2 = 0; Counter_v2 < Array2D.GetLength(1); Counter_v2++)
                {
                    //Hangi Elemanı aldığımızı burada yazıyor => [{Sayaç1}:{Sayaç2}]  
                    //Burada belirlenen elemanın dizide karşılık değeri => {Dizi_adı[Sayaç1, Sayaç2]}
                    Console.WriteLine($"[{Counter_v1}:{Counter_v2}] = {Array2D[Counter_v1, Counter_v2]}");
                }
            }

            // Tanımlama Method 2  ( 2 katlı 3 daire)
            int[,] Array2D_v2 = { { 1, 3, 5 }, { 6, 7, 9 } };

            Console.WriteLine(Array2D_v2[0, 1]);
            Console.WriteLine(Array2D_v2[0, 2]);
            Console.WriteLine(Array2D_v2[1, 0]);
            Console.WriteLine(Array2D_v2[1, 2]);

            Console.WriteLine("İçindeki tüm elemanların sayısı = " + Array2D_v2.Length); // Eleman sayısı
            Console.WriteLine("Array2D_v2.GetLength(0) = " + Array2D_v2.GetLength(0)); // Satır
            Console.WriteLine("Array2D_v2.GetLength(1) = " + Array2D_v2.GetLength(1)); // Sütun

            // For Döngüsü 2 Boyutlu İnteger Dizi elemanlarını yazdırma
            for (int Counter_v1 = 0; Counter_v1 < Array2D_v2.GetLength(0); Counter_v1++)
            {
                for (int Counter_v2 = 0; Counter_v2 < Array2D_v2.GetLength(1); Counter_v2++)
                {
                    //Hangi Elemanı aldığımızı burada yazıyor => [{Sayaç1}:{Sayaç2}]  
                    //Burada belirlenen elemanın dizide karşılık değeri => {Dizi_adı[Sayaç1, Sayaç2]}
                    Console.WriteLine($"[{Counter_v1}:{Counter_v2}] = {Array2D_v2[Counter_v1, Counter_v2]}");
                }
            }

            Console.Clear();

            //-----------------------İki Boyutlu Dizi Oluşturma END----------------------------------

            //-----------------------Üç Boyutlu Dizi Oluşturma Start---------------------------------
            // Birinci Değer Get.Length(0) = Uzunluk / Satır / Dikey
            // İkinci Değer Get.Length(1) = Genişlik / Sütun / Yatay
            // Üçüncü Değer Get.Length(2) = Derinlik / 

            int[,,] arryThreeDimensional = new int[,,] {
                { { 3, 1, 2 },{32,8,87 } }
                , { { 46, 76, 11 }, { 675, 213, 2673 } }
                  , { { 3246, 456, 2131 }, { 656, 7867, 563 } }
                  , { { 2345, 78, 78768 }, { 456, 234, 54654 } } };

            // Foreach ile 3 boyutlu dizi elemanları yazdırma

            foreach(int SrValue3D in arryThreeDimensional)
            {
                Console.WriteLine("Yazıldı =>" + SrValue3D );
            }

            // For döngüsü ile 3 Boyutlu dizi elemanları yazdırma
            for(int counter3d_v2=0; counter3d_v2 < arryThreeDimensional.Rank; counter3d_v2++)
            {
                Console.WriteLine($"arryThreeDimensional.GetLength({counter3d_v2}): " +arryThreeDimensional.GetLength(counter3d_v2));
            }

            // For döngüsü ile 3 boyutlu dizinin eleman sayılarını (Yerlerini) belirterek yazma

            for(int myCounterV1 = 0; myCounterV1< arryThreeDimensional.GetLength(0); myCounterV1++)
            {
                for(int myCounterV2=0; myCounterV2< arryThreeDimensional.GetLength(1); myCounterV2++)
                {
                    for(int myCounterV3=0; myCounterV3< arryThreeDimensional.GetLength(2); myCounterV3++)
                    {
                        Console.WriteLine($"[{myCounterV1}:{myCounterV2}:{myCounterV3}] => {arryThreeDimensional[myCounterV1, myCounterV2, myCounterV3]}");
                    }
                }
            }
            
            //-----------------------Üç Boyutlu Dizi Oluşturma END---------------------------------


             }
        }
   }
