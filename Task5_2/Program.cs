namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20]. Определить количество положительных, отрицательных и равных нулю элементов

            int[] array = new int[10]
                .Select(x => x = new Random().Next(-20, 20)).ToArray();

            int isPlusCount = array.Where(x => x > 0).Count();
            int isMinusCount = array.Where(x => x < 0).Count();
            int isNullCount = array.Where(x => x == 0).Count();

            Console.WriteLine(string.Join(',', array));
            Console.WriteLine($"Положительных: {isPlusCount}\nОтрицательных: {isMinusCount}\nНулей: {isNullCount}\n");
        }
    }
}
