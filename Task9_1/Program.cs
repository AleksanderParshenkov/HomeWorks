using System.Diagnostics;

namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
            //Реализовать класс, в котором указанные значения представлены в виде свойств.
            //Для свойств предусмотреть проверку корректности данных.
            //Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
            //Создать объект на основе разработанного класса. Осуществить использование объекта в программе.

            // Градусы - любое целое число, минуты и секунды в диапазоне 0-59
            Angle angle = new Angle(-365, 30, 47);

            Console.WriteLine($"Заданный угол: {angle.Graduses.ToString()} {angle.Minuts.ToString()} {angle.Secunds.ToString()}");

            double angleToRadians = angle.ToRadians();
            Console.WriteLine($"Количество радиан (с исключением лишних окружностей): {Math.Round(angleToRadians, 4)}");
        }

        public class Angle()
        {
            // Реализовано исключение лишних окружностей. Градусы приводятся к диапазону 0-359
            int graduses = 0;
            public int Graduses {  get { return graduses; }  set { graduses = GetValueGradus(value); } } 

            // Минуты и секунды изначально задаются в диапазоне 0-59 для упрощения, т.е. меньше нельзя, а больше - добавится градус или минута.
            int minuts = 0;
            public int Minuts { get { return minuts; } set { minuts = value; } }

            int secunds = 0;
            public int Secunds { get { return secunds; } set { secunds = value; } }

            public Angle(int grasuses, int minuts, int secunds) : this()
            {
                Graduses = grasuses;
                Minuts = minuts;
                Secunds = secunds;
            }

            public double ToRadians()
            {
                double result = Graduses * Math.PI / 180 + Minuts * Math.PI / 180 / 60 + Minuts * Math.PI / 180 / 60 / 60;
                return result;
            }
        }

        public static int GetValueGradus (int value)
        {
            int result = 0;
            if (value == 0) return 0;
            if (value > 0)
            {
                if (value > 360)
                {
                    int n = (int)Math.Floor((double)value / 360);
                    return (value - n * 360);
                }
                else
                {
                    result = value;
                    return result;
                }
            }
            else
            {
                if (value < -360)
                {
                    int n = (int)Math.Floor((double)Math.Abs(value) / 360);
                    value = value + 360 * n;
                    return value + 360;
                }
                else
                {
                    return 360 + value;
                }                
            }
        }
    }
}
