namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60]
            int x = 0;
            do x = int.Parse(Console.ReadLine());            
            while (x<20 || x>60);

            Console.WriteLine("Ввел !");
        }
    }
}
