namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=».

            int x = int.Parse(Console.ReadLine());  
            int y = int.Parse(Console.ReadLine());
            if (x == y) Console.WriteLine($"{x} = {y}");
            else if (x < y) Console.WriteLine($"{x} < {y}");
            else Console.WriteLine($"{x} > {y}");

            Console.ReadLine();
        }
    }
}
