namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте метод CalcCube для вычисления объема и площади поверхности куба по длине его ребра.
            //Метод должен иметь 3 параметра - длина ребра, out-параметр для объема и out-параметр для площади поверхности.
            // Пример вызова:
            //double edgeLength = 5;
            //CalcCube(edgeLength, out volume, out surfaceArea);
            //Console.WriteLine($"Объем куба: {volume}"); // Объем куба: 125
            //Console.WriteLine($"Площадь поверхности куба: {surfaceArea}"); // Площадь поверхности куба: 150            

            double edgeLength = 5;
            double volume = 0;
            double surfaceArea = 0;

            CalcCube(edgeLength, out volume, out surfaceArea);
            Console.WriteLine($"Объем куба: {volume}"); // Объем куба: 125
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}"); // Площадь поверхности куба: 150
            Console.WriteLine("Hello, World!");
        }

        public static void CalcCube(double edgeLength, out double volume, out double surfaceArea)
        {
            volume = edgeLength * edgeLength * edgeLength;
            surfaceArea = edgeLength * edgeLength * 6;
        }
    }
}
