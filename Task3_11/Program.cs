namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров?
            //Дома можно располагать только параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.

            List<int> land = new List<int>()
            {
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine())
            };

            List<int> house1 = new List<int>()
            {
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine())
            };

            List<int> house2 = new List<int>()
            {
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine())
            };


            bool result = false;

            if (house1[0] + house2[0] <= land[0] && house1[1] + house2[1] <= land[1]) result = true;
            else if (house1[0] + house2[1] <= land[0] && house1[1] + house2[0] <= land[1]) result = true;
            else if (house1[1] + house2[0] <= land[0] && house1[0] + house2[1] <= land[1]) result = true;
            else if (house1[1] + house2[1] <= land[0] && house1[0] + house2[0] <= land[1]) result = true;

            Console.WriteLine(result == true ? "Да" : "Нет");

            Console.ReadLine();
        }
    }
}
