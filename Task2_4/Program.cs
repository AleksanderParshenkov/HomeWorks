namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится четырехзначное число. Поменять местами 2-ую и 4-ую цифру.

            char [] charArray = Console.ReadLine().ToArray();
            char x = charArray[1];
            charArray[1] = charArray[2];
            charArray[2] = x;

            Console.WriteLine(string.Join("", charArray));
            Console.ReadLine();

            // Нет смыста менять строки и чары на инты при таком конкретном условии. Вводится строка - выводится строка. 
        }
    }
}
