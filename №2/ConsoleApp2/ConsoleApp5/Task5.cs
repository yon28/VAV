﻿using System;


namespace ConsoleApp5
{
    class Task5
    {
        static void Main(string[] args)
        {
            /* Числа, кратные трем образуют арифметическую прогрессию. До 1000 таких чисел встречается 999 div 3.
             * Их сумма ((2*3+3*(999 div 3 - 1))/2)*(999 div 3).
             * Числа, кратные пяти образуют арифметическую прогрессию. До 1000 таких чисел встречается 999 div 5.
             * Их сумма ((2*5+5*(999 div 5 - 1))/2)*(999 div 5).
             * Числа, кратные пятнадцати учитаны дважды. Они образуют арифметическую прогрессию. До 999 таких чисел 
             * встречается 999 div 15. Их сумма ((2*15+5*(999 div 15 - 1))/2)*(999 div 15).
*/
            int s = ((2 * 3 + 3 * (333 - 1)) / 2) * 333
            + ((2 * 5 + 5 * (199 - 1)) / 2) * 199
            - ((2 * 15 + 5 * (1000 / 15 - 1)) / 2) * 1000 / 15;


            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i % 3 == 0 &&) 
            //}

            Console.WriteLine("Сумма всех чисел, меньших 1000 и кратных 3 или кратных 5 равна " + s);
            Console.ReadLine();
        }
    }
}
