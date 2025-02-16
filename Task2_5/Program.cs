namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится длина трубы в метрах. Округлить длину до целых в большую сторону.
            Console.WriteLine((int)Math.Round(double.Parse(Console.ReadLine()), 0));
            Console.ReadLine();
        }
    }
}
