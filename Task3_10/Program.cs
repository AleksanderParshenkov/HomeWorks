namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Застройщик построил n домов. Вывести фразу «Мы построили n домов», обеспечив правильное согласование числа со словом «дом»,
            //например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».

            int x = int.Parse(Console.ReadLine());

            List<int> list1 = new List<int>() { 22, 23, 24, 32, 33, 34, 42, 43, 44, 52, 53, 54, 62, 63, 64, 72, 73, 74, 82, 83, 84, 92, 93, 94, 02, 03, 04 };

            List<int> list2 = new List<int>() {21, 22, 31, 41, 51, 61, 71, 81, 91, 101 };            

            if (x == 2 || x == 3 || x == 4) Console.WriteLine($"Мы построили {x} дома");
            else if (x == 1) Console.WriteLine($"Мы построили {x} дом");
            else
            {
                string xToString = x.ToString();
                char last = xToString[xToString.Length - 1];
                char predlast = xToString[xToString.Length - 2];
                int y = int.Parse(predlast.ToString() + last.ToString());

                if (list1.Contains(y)) Console.WriteLine($"Мы построили {x} дома");
                else if (list2.Contains(y)) Console.WriteLine($"Мы построили {x} дом");
                else Console.WriteLine($"Мы построили {x} домов");
            }
            
            Console.ReadLine();
        }
    }
}
