using System.Linq;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввести с клавиатуры предложение.
            // Предложение представляет собой слова, разделенные пробелом.Знаки препинания не используются.
            // Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
            // (пример палиндрома – «А роза упала на лапу Азора»).

            string startString = Console.ReadLine();
            char[] startCharArray = startString.ToCharArray().Select(x => char.ToLower(x)).ToArray();
            startString = string.Join("", startCharArray);

            // Реверс массива
            char[] endCharArray = string.Join(string.Empty, startCharArray.Reverse()).Replace(" ","").ToCharArray();
            string endString = string.Join(string.Empty, endCharArray);            

            for (int i = 0; i < startString.Length; i++)
            {
                if (startString[i] == ' ') endString = endString.Insert(i, " ");
            }

            Console.WriteLine($"Начальная строка: {startString}");
            Console.WriteLine($"Перевернутая строка: {endString}");
            
            Console.WriteLine(startString == endString ? "Да, палиндром": "Нет, не палиндром");
        }
    }
}
