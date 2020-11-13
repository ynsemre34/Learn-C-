using System;
using System.Collections.Generic;
using System.Linq;


namespace İKİBOYUT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myFirstArray = new int[3, 3];
            myFirstArray[0, 0] = 2;
            myFirstArray[0, 1] = 4;
            myFirstArray[0, 2] = 6;
            myFirstArray[1, 0] = 8;
            myFirstArray[1, 1] = 10;
            myFirstArray[1, 2] = 12;
            myFirstArray[2, 0] = 14;
            myFirstArray[2, 1] = 16;
            myFirstArray[2, 2] = 18;

            int[,] mySecondArray = new int[3, 3];
            mySecondArray[0, 0] = 3;
            mySecondArray[0, 1] = 5;
            mySecondArray[0, 2] = 7;
            mySecondArray[1, 0] = 9;
            mySecondArray[1, 1] = 11;
            mySecondArray[1, 2] = 13;
            mySecondArray[2, 0] = 15;
            mySecondArray[2, 1] = 17;
            mySecondArray[2, 2] = 19;

            int[,] myThirdArray = new int[3, 3];

            for(int counter1=0; counter1< myThirdArray.GetLength(0); counter1++)
            {
                for(int counter2=0; counter2< myThirdArray.GetLength(1); counter2++)
                {
                    myThirdArray[counter1, counter2] = myFirstArray[counter1, counter2] + mySecondArray[counter1, counter2];
                }
            }

            for(int counter3=0; counter3< myThirdArray.GetLength(0); counter3++)
            {
                for (int counter4 = 0; counter4 < myThirdArray.GetLength(1); counter4++)
                {
                    Console.WriteLine($"[{counter3}:{counter4}].Dizi elemanı => {myThirdArray[counter3, counter4]}");
                }
            }


        }
    }
}
