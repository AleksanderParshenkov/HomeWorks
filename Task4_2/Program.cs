namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n
            int x = int.Parse(Console.ReadLine());
            double result = 0;
            for (int i = 1; i <= x; i++)
            {
                result += Math.Round((double)1 / i, 10);
            }

            Console.WriteLine(result);
        }
    }
}
