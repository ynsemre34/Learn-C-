using System;
using System.Collections.Generic;
using System.Threading;

namespace Lecturer3
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------Time Codes Start-------------------------------
            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings

            DateTime myDate = DateTime.Now;
            
            Console.WriteLine("ShortTime pattern (t) is below");
            var vrFormattedString = return_formatted_DateTime(myDate, "{0:t}");
            Console.WriteLine(vrFormattedString);

            Console.WriteLine("LongTime pattern (T) is below");
            vrFormattedString = return_formatted_DateTime(myDate, "{0:T}");
            Console.WriteLine(vrFormattedString);

            // Zaman karakterleri 
            Console.WriteLine("dd =  01 ayın gününden itibaren, dddd Haftanın gününün tam adı, hh = 01'den 12'ye 12 saatlik bir zaman biçimi kullanarak.");
            vrFormattedString = return_formatted_DateTime(myDate, "{0:dd dddd hh}");
            Console.WriteLine(vrFormattedString);

            // Saat ve dakika + Gün/ay/yıl denemesi 
            vrFormattedString = return_formatted_DateTime(myDate, "{0:hh:mm:ss  dd/dddd/yyyy}");
            Console.WriteLine(vrFormattedString);

            //Geçerli dakika, yıl, saniye, saat
            Console.WriteLine("dakika: " + DateTime.Now.Minute);
            Console.WriteLine("saniye : " + myDate.Second);
            Console.WriteLine("yıl : " + myDate.Year);
            Console.WriteLine("saat : " + myDate.Hour);

            //Geçerli zamanın üzerine süre eklemek
            DateTime myPlus360Hours = myDate.AddHours(360);
            vrFormattedString = return_formatted_DateTime(myDate, "{0:hh:mm:ss  dd/dddd/yyyy}");
            Console.WriteLine("360 Saat eşittir :" + vrFormattedString);

            Console.Clear();

            //----------------------Time Codes End-------------------------------

            //----------------------Lists Method Start-------------------------------

            List<string> lstMyList = new List<string>();
            lstMyList.Add("Yunus Emre");   //Ad
            lstMyList.Add("Bitkay");       //Soyad
            lstMyList.Add("Toros Üniversitesi");    //Üniversite
            lstMyList.Add("Yazılım Mühendisliği (İngilizce)");  //Bölüm
            lstMyList.Add("20");    //Yaş
            lstMyList.Add("Apple'da Mühendis");     //Hedef

            //Method 1 
            Console.WriteLine("Adım {0}, soyadım {1}, yaşım {4}, {2}'nin {3} bölümünü okumaktayım.Hedefim bir gün {5} olabilmek", lstMyList[0],
                lstMyList[1], lstMyList[2], lstMyList[3], lstMyList[4], lstMyList[5]);

            //Method 2
            string srSentence = string.Format("Adım {0}, soyadım {1}, yaşım {4}, {2}'nin {3} bölümünü okumaktayım.Hedefim bir gün {5} olabilmek", lstMyList[0],
                lstMyList[1], lstMyList[2], lstMyList[3], lstMyList[4], lstMyList[5]);
            Console.WriteLine(srSentence);
            
            //Method 3 (Parantez içi önemlidir virgülden sonra gelen liste sıralaması değil!
            srSentence = string.Format("Adım {0}, soyadım {1}, yaşım {4}, {2}'nin {3} bölümünü okumaktayım.Hedefim bir gün {5} olabilmek", lstMyList[0],
                lstMyList[1], lstMyList[2], lstMyList[3], lstMyList[4], lstMyList[5]);
            Console.WriteLine(srSentence);

            //Method 4 İfadeyi iki defa yazdırmak için iki defa {value} şeklinde yazılır.
            srSentence = string.Format("Adım {0} {0}, soyadım {1} {1}, yaşım {4} {4}, {2} {2}'nin {3} {3} bölümünü okumaktayım.Hedefim bir gün {5} olabilmek", lstMyList[0], lstMyList[1], lstMyList[2], lstMyList[3], lstMyList[4], lstMyList[5]);
            Console.WriteLine(srSentence);

            //Method 5 başında $ işareti yazarak {lstMyList[value]} biçiminde de yazılabilmektedir.
            srSentence = $"Adım {lstMyList[0]}, soyadım {lstMyList[1]}, yaşım {lstMyList[04]}, {lstMyList[2]}'nin {lstMyList[3]} bölümünü okumaktayım.Hedefim bir gün {lstMyList[5]} olabilmek";
            Console.WriteLine(srSentence);

            //Method 6 
            srSentence = "Adım " +lstMyList[0]+ ", soyadım " +lstMyList[1]+ ", yaşım " +lstMyList[4]+ "," + lstMyList[2] + "'nin" +lstMyList[3]+ " bölümünü okumaktayım.Hedefim bir gün " +lstMyList[5]+ " olabilmek";
            Console.WriteLine(srSentence);

            Console.Clear();

            //----------------------Lists Method End-------------------------------


            //----------------------Sayısal Dönüşümler Start-----------------------

            //Double + String İfade Toplamı ne olur?
            var myNumber_v1 = 23 + "36,503";
            Console.WriteLine("Double + String İfade Toplamı: " + myNumber_v1);

            //Double + İnteger İfade Toplamı ne olur?
            var myNumber_v2 = 53 + 23.38;
            Console.WriteLine("Double + İnteger İfade Toplamı: " + myNumber_v2);

            //Geçerli zamana süre ekleme methodu (Gün, Saat, Dakika, Saniye)
            var myNumber_v3 = DateTime.Now + new TimeSpan(14, 11, 12, 13);
            Console.WriteLine("Geçerli zaman + eklenmek istenen süre = " + myNumber_v3);
            
            //Sayı Yuvarlama Methodu (Value, Virgülden sonra yazılcak karakter sayısı)
            var myNumber_v4 = 46.48513456 + 10;
            myNumber_v4 = Math.Round(myNumber_v4, 4);
            Console.WriteLine(myNumber_v4);

            // ("N Value") virgülden sonra kaç sayı yazılıcak ?
            var myNumber_v5 = 53.54329183921 + 23;
            Console.WriteLine("String => Double + integer =" + myNumber_v5.ToString("N3"));
            Console.WriteLine("String => Double + integer =" + myNumber_v5.ToString("N0"));
            
            //Double ifadeyi yuvarlama
            var vrFlooredNumber = Math.Floor(myNumber_v5);
            Console.WriteLine("floored double = " + vrFlooredNumber);

            //İnteger her zaman bölen sayısına yuvarlar (Ex. 26/4 = 6.5 => 6)
            var myAction = 26 / 4;
            Console.WriteLine("İnteger 26/4 = {0}", +myAction);

            Console.Clear();

            //----------------------Sayısal Dönüşümler End-----------------------


            //----------------------Sayısal Kültür Dönüşümleri Start-------------

            //Geçerli kültürün hangi dil ve ülkeye ait olduğunu öğrenmek için yazılır.
            Console.WriteLine("Geçerli kültür : " + Thread.CurrentThread.CurrentCulture.Name);

            // US Ve TR Dillerinde binliklerin ayrımı.
            double myDoubleValue = 7864932.52;
            Console.WriteLine("7864932.52 sayısının en-US kültüründe yazımı: " + myDoubleValue.ToString("N2"));

            // TR => en-US dönüştürme
            string srMyFirstValue  = "3,593,238.53";
            string srMySecondValue = "3.593.238,53";

            var DoubleConverted1 = 0.0;
            var DoubleConverted2 = Convert.ToDouble(srMySecondValue);

            double.TryParse(srMyFirstValue, out DoubleConverted1);

            Console.WriteLine("in en-US {0} is converted to a dobule as {1} and {2} is converted to a double as {3}", srMyFirstValue, DoubleConverted1, 
                srMySecondValue, DoubleConverted2);

            // Şimdi dilimizi en-US yapalım.
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            // Şimdi de kontrol edelim.
            Console.WriteLine("Geçerli kültür : " + Thread.CurrentThread.CurrentCulture.Name);

            // Şimdi de en-US kültüründe (7864932.52) değerimizi ekrana yazalım.
            Console.WriteLine("7864932.52 değeri en-US kültüründe böyle gözükür: " +myDoubleValue.ToString("N2"));

            // Geçerli kültürle çevirme ve kültür dışındaki ifadelere neler olduğu aşağıda yazmaktadır. 
            var DblConverted_v1 = -1.0;
            var DblConverted_v2 = -2.0;

            //TryParse methodu string değerin istenen veri tipine dönüşüp dönüşmeyeceğini kontrol eder.
            bool BlResult1 = double.TryParse(srMyFirstValue, out DblConverted_v1);
            bool BlResult2 = double.TryParse(srMySecondValue, out DblConverted_v2);

            //Sorgulama
            if (BlResult1 == false)
            {
                DblConverted_v1 = -2;
            }
            if (BlResult2 == false)
            {
                DblConverted_v2 = -3;
            }
            
            //Sonuç
            Console.WriteLine("in tr-TR {0} is converted to a double as {1} and {2} is converted to a double as {3}",
                srMyFirstValue, DblConverted_v1, srMySecondValue, DblConverted_v2);

            
            //----------------------Sayısal Kültür Dönüşümleri End-------------

        }

        private static string return_formatted_DateTime(DateTime myDateTime, string srDateFormat)
        {
            return string.Format(srDateFormat, myDateTime);
        }
    }
}
