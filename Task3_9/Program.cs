﻿namespace Task3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести «Да», если оно попадает в диапазон (-∞; -10] Ս [10; +∞), и «Нет» в противном случае.

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(x <= -10 || x >= 10 ? "Да" : "Нет");            

            Console.ReadLine();
        }
    }
}
