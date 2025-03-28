namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишите метод PrintNumbers, который выводит на экран числа из массива.
            // У метода должен быть необязательный параметр reverse, который по умолчанию равен false.Если reverse равен true,
            // числа выводятся в обратном порядке.
            // Пример вызова:
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //PrintNumbers(numbers); // Вывод: 1 2 3 4 5
            //PrintNumbers(numbers, true); // Вывод: 5 4 3 2 1
            int[] numbers = { 1, 2, 3, 4, 5 };

            PrintNumbers(numbers); // Вывод: 1 2 3 4 5

            PrintNumbers(numbers, true); // Вывод: 5 4 3 2 1
            
        }

        public static void PrintNumbers (int[] numbers, bool reverse = false)
        {
            if (reverse) Console.WriteLine(string.Join(' ', numbers.Reverse()));
            else Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
