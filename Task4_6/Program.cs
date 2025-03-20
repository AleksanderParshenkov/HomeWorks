namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить, является ли оно степенью 2-ки?
            double x = double.Parse(Console.ReadLine());
            do x = x / 2;
            while (x > 1);

            if (x == 1) Console.WriteLine("Да"); 
            else Console.WriteLine("Нет");
        }
    }
}
