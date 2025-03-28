namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100]. Определить, каких чисел больше – четных или нечетных

            int[] array = new int[10]
                .Select(x => x = new Random().Next(0,100)).ToArray();

            int isEvenCount = array.Where(x => x % 2 == 0).Count(); 

            int isNotEvenCount = array.Where(x => x % 2 == 1).Count();

            string result = "";

            if (isEvenCount != isNotEvenCount) result = isEvenCount > isNotEvenCount ? "Четных больше" : "Нечетных больше";
            else result = "Поровну";

            Console.WriteLine(string.Join(',', array) + "\n" + result);
        }
    }
}
