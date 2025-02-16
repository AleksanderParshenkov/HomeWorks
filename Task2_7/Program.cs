namespace Task2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся два числа. Обменять их местами, не используя третью переменную.

            Console.WriteLine("Введите первое число");
            double a =double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double b = double.Parse(Console.ReadLine());

            // Вариант 1 (основной)
            (a, b) = (b, a); 

            // Вариант 2
            //a = a + b; 
            //b = a - b;
            //a = a - b;


            Console.WriteLine($"Первое число = {a}, Второе число = {b}");
            Console.ReadLine();
        }
    }
}
