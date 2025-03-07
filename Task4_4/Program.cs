namespace Task4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double result = 1;

            for (int i = b; i < 0; i++) result = Math.Round((double)result / a, 10); 

            Console.WriteLine(result);
        }    
    }
}
