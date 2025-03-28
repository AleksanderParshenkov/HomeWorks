using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Составить регулярное выражение для проверки корректности номера телефона.
            //Корректный номер имеет формат +7(123)456-78-90.
            string n = Console.ReadLine();

            string pattern = @"^\+[0-9]{1}\([0-9]{3}\)[0-9]{3}\-[0-9]{2}\-[0-9]{2}$";

            Regex regex = new Regex(pattern);
            
            bool result = false;

            if (regex.IsMatch(n)) result = true;

            Console.WriteLine(result? "Корректно" : "Ошибка");
        }
    }
}
