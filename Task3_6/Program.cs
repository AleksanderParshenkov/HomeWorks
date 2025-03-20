namespace Task3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) Console.WriteLine("Да");
            else Console.WriteLine("Нет");

            Console.ReadLine();
        }
    }
}
