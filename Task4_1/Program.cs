namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.          
            int x = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result = result * i;
            }

            Console.WriteLine(result);
        }
    }
}
