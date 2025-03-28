namespace Task5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 5 случайных чисел из диапазона [0, 10].
            //Найти два наибольших элемента. Например, среди чисел {4, 8, 0, 9, 3} два наибольших числа – 9 и 8.
            //Среди чисел {5, 9, 1, 9, 3} два наибольших числа – 9 и 9

            int[] array = new int[10]
                .Select(x => x = new Random().Next(0, 10)).ToArray().OrderByDescending(x => x).ToArray();

            Console.WriteLine(string.Join(',', array));
            Console.WriteLine($"Это числа: {array[0]} и {array[1]}");

        }
    }
}
