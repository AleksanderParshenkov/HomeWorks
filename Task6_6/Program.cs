using System.Text.RegularExpressions;

namespace Task6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Составить регулярное выражение для проверки корректности пароля.
            //Пароль должен состоять минимум из 14 символов и иметь в составе минимум одну цифру, заглавную букву, строчную букву и специальный символ из набора !#;%:?*.
            //Запрашивать у пользователя пароль до тех пор, пока он не введет пароль, удовлетворяющий регулярному выражению.

            // Пароль для проверки: 1234567890Ab!d

            string str = Console.ReadLine();

            string pattern = @"^(?=.{14,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[!#;%:?*]).*$";

            Regex regex = new Regex(pattern);

            bool result = false;

            if (regex.IsMatch(str)) result = true;

            Console.WriteLine(result ? "Корректно" : "Ошибка");
        }
    }
}
