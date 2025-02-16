namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится длина трубы в метрах. Округлить длину до 0,5
            //Примечание. Не использовать условные операторы. Разрешено использовать только математические операции и методы библиотеки Math.

            double start = double.Parse(Console.ReadLine());
            int x = (int) Math.Round(start / 0.5,0);
            double result = x * 0.5;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
