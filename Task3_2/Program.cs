namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводятся три числа. Вывести большее их них.

            List<int> list = new List<int>(3)
            {                
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine())
            };

            Console.WriteLine(list.Max());


        }
    }
}
