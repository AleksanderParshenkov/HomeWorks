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

            Angle angle = new Angle(5, 30, 47);
            double angleToRadians = angle.ToRadians();
            Console.WriteLine(angleToRadians);
        }

        public class Angle()
        {
            int grasuses
            {
                get
                {
                    return grasuses;
                }
                set
                {
                    grasuses = GetValue(value); 
                }
            }
            int minuts
            {
                get
                {
                    return minuts;
                }
                set
                {
                    minuts = GetValue(value);
                }
            }
            int secunds
            { 
                get
                {
                    return secunds;
                }
                set
                {
                    secunds = GetValue(value);
                }
            }

            public Angle (int grasuses, int minuts, int secunds) : this ()
            {
                this.grasuses = grasuses;
                this.minuts = minuts;
                this.secunds = secunds;
            }

            public double ToRadians()
            {
                return (grasuses + minuts / 60 + secunds / 360) * (Math.PI) / 180;
            }
        }

        public static int GetValue (int value)
        {
            if (value > 0)
            {
                if (value > 360)
                {
                    int n = (int)Math.Floor((double)value / 360);
                    return (value - n * 360);
                }
                else
                {
                    return value;
                }
            }
            else
            {
                if (value < -360)
                {
                    int n = (int)Math.Floor((double)Math.Abs(value) / 360);
                    value = value + 360 * n;
                    return 360 - value;
                }
                else
                {
                    return 360 - value;
                }                
            }
        }
    }
}
