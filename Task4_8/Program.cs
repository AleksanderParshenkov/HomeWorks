using System;

namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести его в зеркальном виде. Количество цифр в числе заранее неизвестно. Не использовать строки
            int x = int.Parse(Console.ReadLine());
            int result = 0;
            while (x > 0)
            {
                result = result * 10 + x % 10;
                x = (int) Math.Round((double)( x / 10));
            }

            Console.WriteLine(result);


        }
    }
}
