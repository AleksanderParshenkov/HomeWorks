namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввести с клавиатуры предложение.
            // Предложение представляет собой слова, разделенные пробелом.
            // Знаки препинания не используются. Найти самое длинное слово в строке.

            string[] str = Console.ReadLine().Split(' ');

            string result = "";

            foreach (string s in str) if (s.Length > result.Length) result = s;
            
            Console.WriteLine(result);
        }
    }
}
