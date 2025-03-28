namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Смоделируйте работу простого калькулятора.
            //Программа должна запрашивать 2 целых числа, а затем – код операции(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное)
            //После этого на консоль выводится ответ. Используйте обработку деления на ноль(DivideByZeroException),
            //нечислового ввода(FormatException).

            int x = -2147483647;
            int y = -2147483647;
            string oper;
            
            while (x == -2147483647)
            {
                Console.WriteLine($"Введите первое число:");
                try { x = int.Parse(Console.ReadLine()); } catch (FormatException ex) { Console.WriteLine(ex.Message); }
            }

            while (y == -2147483647)
            {
                Console.WriteLine($"Введите второе число:");
                try { y = int.Parse(Console.ReadLine()); } catch (FormatException ex) { Console.WriteLine(ex.Message); }
            }

            Console.WriteLine($"Введите символ операции:");
            oper = Console.ReadLine();

            switch (oper)
            {
                case "+":
                    Console.WriteLine($"Итог: {x +y}");
                    break;
                case "-":
                    Console.WriteLine($"Итог: {x - y}");
                    break;
                case "*":
                    Console.WriteLine($"Итог: {x * y}");
                    break;
                case "/":
                    try { Console.WriteLine($"Итог: {x / y}"); }
                    catch (DivideByZeroException ex) { Console.WriteLine($"Ошибка деления на ноль: {ex.Message}"); }
                    break;

                default:
                    Console.WriteLine("Символ оператора указан не верно");
                    break;
                    
            }
        }
    }
}
