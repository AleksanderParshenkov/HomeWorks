namespace Task3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.
            int x = int.Parse(Console.ReadLine());

            if (Math.Abs(x /10) >= 1 && Math.Abs(x / 10) < 10) Console.WriteLine("Да");
            else Console.WriteLine("Нет");

            Console.ReadLine();
        }
    }
}
