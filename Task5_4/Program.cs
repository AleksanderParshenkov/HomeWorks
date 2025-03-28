namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10]. Перевернуть массив, т.е. переставить элементы массива в обратном порядке

            int[] array = new int[10]
                .Select(x => x = new Random().Next(0, 10)).ToArray();

            Console.WriteLine(string.Join(',', array));
            Console.WriteLine(string.Join(',', array.Reverse()));
        }
    }
}
