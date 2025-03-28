namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать двумерный массив из 10 строк и 5 столбцов. Заполнить его случайными числами в диапазоне [0, 10].
            //Определить максимальный элемент в каждой строке

            int[][] array = new int[10][].Select(x => x = new int [5].Select(y => y = new Random().Next(0, 10)).ToArray())
                .ToArray();

            foreach (int[] item in array)
            {
                Console.WriteLine(string.Join(' ', item));
            }

            foreach (int[] item in array)
            { 
                Console.WriteLine($"Максимальной элемент строки: {item.Max()}");
            }
        }
    }
}
