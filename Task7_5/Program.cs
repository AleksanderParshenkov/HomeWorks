namespace Task7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишите перегруженные методы Multiply, которые могут умножать два числа(целые или дробные) и возвращать результат.
            // Пример вызова:
            //Console.WriteLine(Multiply(2, 3)); // Вывод: 6
            //Console.WriteLine(Multiply(2.5, 3.5)); // Вывод: 8.75

            Console.WriteLine(Multiply(2, 3)); // Вывод: 6
            Console.WriteLine(Multiply(2.5, 3.5)); // Вывод: 8.75
        }

        public static int Multiply (int a, int b)
        {
            return a * b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
