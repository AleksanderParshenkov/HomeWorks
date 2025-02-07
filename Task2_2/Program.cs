namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Угол а задан в градусах, минутах и секундах.
            //Найти его величину в радианах.
            //Рекомендации по тестированию: проверить работоспособность программы для углов, больших развернутого, а также для отрицательных углов.

            Console.WriteLine("Введите целое число градусов угла");
            int graduses = int.Parse(Console.ReadLine());
            int allSecunds = graduses * 60 * 60; 

            Console.WriteLine("Введите целое число минут угла");
            int minutes = int.Parse(Console.ReadLine());
            allSecunds = allSecunds + minutes * 60;

            Console.WriteLine("Введите целое число секунд угла");
            int secunds = int.Parse(Console.ReadLine());
            allSecunds = allSecunds + secunds;

            double gradusResult = Math.Round((double) allSecunds / 60 / 60 , 3);

            double radians = Math.Round(gradusResult *  Math.PI / 180, 3);

            Console.WriteLine(radians);
        }
    }
}
