using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросите у пользователя имя, возраст и город. Сформируйте строку в формате:
            //"Имя: [имя], Возраст: [возраст], Город: [город]"
            //с использованием StringBuilder.

            StringBuilder sb = new StringBuilder();
            string name;
            string year;
            string city;

            Console.WriteLine("Укажите имя, возраст и город по очереди:");
            sb.Append($"Имя: {name = Console.ReadLine()}, Возраст: {year = Console.ReadLine()}, Город: {city = Console.ReadLine()}");

            Console.WriteLine(sb.ToString());

            // Не понял я это задание. Не понял
        }
    }
}
