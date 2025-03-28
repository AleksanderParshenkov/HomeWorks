using System.Runtime.CompilerServices;

namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Два треугольника заданы длинами своих сторон. Определите, площадь какого из них больше
            //(создайте метод Square для вычисления площади треугольника по длинам его сторон).
            //Для решения задачи можно использовать формулу Герона.

            Triangle triangle_1 = new Triangle(2, 3, 4);
            Triangle triangle_2 = new Triangle(4, 5, 6);

            double triangle_1Area = triangle_1.Square();
            double triangle_2Area = triangle_2.Square();

            if (triangle_1Area == triangle_2Area) Console.WriteLine($"Площади равны");
            else Console.WriteLine(triangle_1Area > triangle_1Area ? $"Первый больше второго" : $"Второй больше первого");

        }

        public class Triangle()
        { 
            private int A { get; }
            private int B { get; }
            private int C { get; }

            public Triangle(int a,  int b, int c) : this() 
            {
                A = a;
                B = b; 
                C = c;
            }  
            
            public double Square()                 
            {
                double p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
    }
}
