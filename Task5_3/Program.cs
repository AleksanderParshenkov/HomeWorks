namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50]. Найти и вывести значение максимального, минимального элементов и их индексы

            int[] array = new int[10]
                .Select(x => x = new Random().Next(0, 50)).ToArray();

            int maxDigit = array.Max(x => x);
            int minDigit = array.Min(x => x);

            int indexMax = array.ToList().FindIndex(x => x == maxDigit);
            int indexMin = array.ToList().FindIndex(x => x == minDigit);

            Console.WriteLine(string.Join(',', array));
            Console.WriteLine($"Максимально: {maxDigit}, его первый индекс: {indexMax}");
            Console.WriteLine($"Максимально: {minDigit}, его первый индекс: {indexMin}");
        }
    }
}
