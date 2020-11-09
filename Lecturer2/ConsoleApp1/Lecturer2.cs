using System;

namespace lecturer2
{
    class lecturer2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ben String bir ifadeyim.");

            Boolean myBoolValue = true;

            Console.WriteLine("Ben String bir ifadeyim " +myBoolValue);

            char myCharValue = 'A';
            Console.WriteLine("Benim karakterim: " + myCharValue);

            Console.Clear();

            // -----------------------------------//
            //Virgülden sonra 25 karakter yazdırır.
            decimal myDecimalValue = 547.032049032932189321892183213213M;
            Console.WriteLine("My Demical Value is " + myDecimalValue);
            //Virgülden sonra 4 karakter yazdırır.
            float myFloatValue = 523.4132183921832982931832198F;
            Console.WriteLine("My Float value is " + myFloatValue);

            //Virgülden sonra 13 karakter yazdırır.
            double myDoubleValue = 523.3215324236645345435435;
            Console.WriteLine("My Double Value is " + myDoubleValue);

            Console.WriteLine();

            Console.WriteLine("Max value of double {double.MaxValue}");
            Console.WriteLine($"Max value of float { float.MaxValue}");
            Console.WriteLine($"Max value of decimal { decimal.MaxValue}");
            Console.WriteLine($"Max value of double{ double.MaxValue}");

            //Max Value bilimsel gösterim olmadan değeri
            Console.WriteLine($"max value of double without scientific notation {double.MaxValue.ToString("0." + new string('#', 339))}");
            
            //İnteger Max and Min
            Console.WriteLine($"max value of integer {int.MaxValue}");
            Console.WriteLine($"Min value of integer {int.MinValue}");

            Console.Clear();

            // -----------------------------------//

            Console.Write("Bu cümle devam edicek.");
            Console.Write(" bu aynı satırda olucak.");
            Console.Write("\n");
            Console.Write("Bu cümle yeni satıra geçicek.");

            //Cümle içinde tırnak içine alıncak bir veya birden fazla kelimeyi \"--\" ile yazılır.
            Console.WriteLine("Bu ülkede \"Yazılımcı\" olmak zor. ");
            
            //Ters eğik yazmak için // yazmak yeterlidir.
            Console.WriteLine("Ters eğik işareti \\ ");

            //Yatay geçiş ve geçişsiz tab
            Console.WriteLine("Yatay geçişsiz tab: value 1 value 2 value 3 ");
            Console.WriteLine("Yatay geçişli  tab: value 1\tvalue 2\tvalue 3\t ");
            //Dikey geçiş 
            Console.WriteLine("dikey tab: value 1\vvalue 2\vvalue 3\v ");

            Console.Clear();
            
            // -----------------------------------//

            string mybaseString = "my school number is {0} , my graduation score is {1}";
            Console.WriteLine("base string\t" + mybaseString);

            string myFormattedString = string.Format(mybaseString, 250, 30);
            Console.WriteLine("formatted string\t" + myFormattedString);

            //Örnek çalışmam

            string mybaseStringv2 = "Türkiye yazılımcı maaşı {0} iken, sizden {1}'luk çalışma bekliyorlar.";
            string myFormattedStringv2 = string.Format(mybaseStringv2, 2500, 10);
            Console.WriteLine(myFormattedStringv2);

            Console.Clear();

            // -----------------------------------//

            sbyte my_sbyte = 123; // -128 to 127 // Signed 8-bit integer = 1 byte in memory
            
            byte my_byte = 214; // 0 to 255 // Unsigned 8-bit integer = 1 byte in memory

            short my_short = 3241; // -32,768 to 32,767	Signed 16-bit integer = 2 bytes in memory
            //Int16 = short

            ushort my_ushort = 3241; // 0 to 65,535	Unsigned 16-bit integer = 2 bytes in memory
            // UInt16 = ushort

            int my_int = 325341; //-2,147,483,648 to 2,147,483,647    Signed 32 - bit integer = 4 bytes in memory

            //Int32 = int

            uint my_uint = 325341; //0 to 4,294,967,295 Unsigned 32 - bit integer = 4 bytes in memory

            //UInt32 = uint

            long my_long = 45643532432; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 Signed 64 - bit integer = 8 bytes in memory

            //Int64 = long

            ulong my_ulong = 5465745436575; // 0 to 18,446,744,073,709,551,615 Unsigned 64 - bit integer = 8 bytes in memory

            byte number1 = 1;

            // -----------------------------------//

            //so 4 gbyte ram memory is equal to = 4 * 1024 mbytes = 4 * 1024 * 1024 kbytes = 4 * 1024 * 1024 * 1024 bytes = 4 * 1024 * 1024 * 1024 * 8 bits

            Int64 numberofBytesin4GB = 4L * 1024L * 1024L * 1024L * 8L;

            Console.WriteLine("4 gbytes in bits = " + numberofBytesin4GB);

            //Max.Value kullanımı
            ulong bigNumber = ulong.MaxValue;
            Console.WriteLine($"ulong {bigNumber} written as like this in base 2 : " + Convert.ToString((long)bigNumber, 2) + " - lenght: " + Convert.ToString((long)bigNumber, 2).Length);

            Int16 variable1 = Int16.MaxValue;
            Console.WriteLine($"Int16 {variable1} written as like this in base 2 : " + Convert.ToString((short)variable1, 2) + " - lenght: " + Convert.ToString((short)variable1, 2).Length);

            Int32 variable2 = Int32.MaxValue;
            Console.WriteLine($"Int32 {variable2} written as like this in base 2 : " + Convert.ToString((int)variable2, 2) + " - lenght: " + Convert.ToString((int)variable2, 2).Length);

            long bigNumberv2 = long.MaxValue;
            Console.WriteLine($"singed long {bigNumberv2} written as like this in base 2 : " + Convert.ToString((long)bigNumberv2, 2) + " - lenght: " + Convert.ToString((long)bigNumberv2, 2).Length);

        }
    }
}
