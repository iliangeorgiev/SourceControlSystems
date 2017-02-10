﻿using System;

namespace Text_and_Other_Types__Variables
{
   public class Program
    {
       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                bool spesial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", num, spesial);
            }

        }
    }
}
