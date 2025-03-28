namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишите метод FindMax, который принимает переменное количество чисел и возвращает максимальное значение.
            // Используйте ключевое слово params.
            // Пример вызова:
            //int maxNumber = FindMax(10, 25, 5, 30, 15);
            //Console.WriteLine($"Max number: {maxNumber}"); // Вывод: Max number: 30

            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}"); // Вывод: Max number: 30
        }

        public static int FindMax (params int[] numbers)
        {
            return numbers.Max();
        }
    }
}
