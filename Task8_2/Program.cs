using System;

namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите метод ValidateAge, проверяющий корректность возраста. Если возраст:
            //•    < 0 - выбросить ArgumentException("Возраст не может быть отрицательным"),
            //•    > 150 - выбросить ArgumentOutOfRangeException("Слишком большой возраст").

            Console.WriteLine("Введи свой возраст:");
            string ageString = Console.ReadLine();
            int age = 0;

            try
            {
                age = int.Parse(ageString);
                if (age > 150) Console.WriteLine(new ArgumentOutOfRangeException($"Cлишком большой возраст: {age}, age"));
                else if (age < 0) Console.WriteLine(new ArgumentException($"Возраст не может быть отрицательным: {age}, age"));
                else Console.WriteLine($"Ваш возраст: {age}");
            }
            catch (FormatException ex) { Console.WriteLine($"Введено не целое число: {ageString}, ageString\n {ex.Message}"); }
        }    
    }
}
