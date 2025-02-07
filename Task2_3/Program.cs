namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится целое число дюймов

            int inches = int.Parse(Console.ReadLine());
            double startValue = Math.Round(inches * 25.4, 1, MidpointRounding.ToEven);

            int meters = (int)Math.Floor(startValue / 1000);

            startValue = startValue - meters * 1000;
            int centimeters = (int)Math.Floor(startValue / 10);

            startValue = startValue - centimeters * 10;
            double milimeters = Math.Round(startValue, 1);

            Console.WriteLine($"{inches} дюйм = {meters} м {centimeters} см {milimeters} мм");
        }
    }
}
