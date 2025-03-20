namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить количество цифр в числе
            int result = Console.ReadLine()
                .ToArray()
                .Where(x => char.IsDigit(x))
                .Count();

            Console.WriteLine(result);
        }
    }
}
