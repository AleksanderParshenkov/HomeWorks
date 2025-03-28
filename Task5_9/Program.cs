namespace Task5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Матрицу A(m, n) (m и n – константы со значением на ваш выбор) заполнить натуральными числами от 1 до n*m по спирали,
            //начинающейся в левом верхнем углу и закрученной по часовой стрелке

            //Например,
            //1  2  3  4  5
            //16 17 18 19 6
            //15 24 25 20 7
            //14 23 22 21 8
            //13 12 11 10 9

            int n = new Random().Next(0, 50);
            int m = new Random().Next(0, 50);

            int[][] matrix = new int[n][];
        }
    }
}
