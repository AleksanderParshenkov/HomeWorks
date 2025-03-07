namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводятся три разных числа. Вывести медиану – среднее по величине число.

            List<int> list = new List<int>(3)
            {
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine())                
            };

            Console.WriteLine(Math.Round((list.Select(x => double.Parse(x.ToString())).Sum()/list.Count()),2));

            Console.ReadLine();
        }
    }
}
