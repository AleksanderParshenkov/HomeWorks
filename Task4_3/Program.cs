namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 0; i < b; i++) result = result * a;

            Console.WriteLine(result);
        }
    }
}
