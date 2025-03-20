namespace Task3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.

            int x = int.Parse(Console.ReadLine());

            if (x % 10 == 0) Console.WriteLine("Да");
            else Console.WriteLine("Нет");

            Console.ReadLine();
        }
    }
}
