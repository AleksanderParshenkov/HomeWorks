namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводятся четыре числа. Вывести большее из них.

            List<int> list = new List<int>(4)
            {
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine())
            };

            Console.WriteLine(list.Max());

            Console.ReadLine();
        }
    }
}
