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

            // Для решения честно взял часть кода со https://stackoverflow.com/questions/1183013/spiral-algorithm-in-c-sharp
            // В жизни такие матрицы не применяются, а писать такое долго. Иногда проще взять что-то готовое и быстро в этом разобраться. 

            int m = 0, n = 0, start = 0, step = 0;
            bool errorOcured = false;
            Console.WriteLine("====Спиральная матрица====\n");
            try
            {
                Console.WriteLine("Введите количество строк и столбцов матрицы:");
                Console.Write("Строк (m)? ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Столбцов (n)? ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите начальное (наименьшее) значение ячейки матрицы: ");
                start = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите шаг изменения значения: ");
                step = Convert.ToInt32(Console.ReadLine());
                if (m < 0 || n < 0 || start < 0 || step < 0) throw new FormatException();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Некорректные данные. [Details: {0}]", e.Message);
                Console.WriteLine("Программа не может найти выход...");
                errorOcured = true;
            }

            if (!errorOcured)
            {
                int[,] mat = new int[m, n];
                mat = initMatrix(m, n, start, step);

                //Console.WriteLine("\nIntial matrix generated is:");
                //displayMatrix(mat, m, n);

                Console.WriteLine("\nСпиральная матрица:");
                mat = calculateSpider(mat, m, n);
                displayMatrix(mat, m, n);
            }
            Console.Write("\nНажмите любую кнопку для выхода из программы");
            Console.Read();
        }
        private static int[,] initMatrix(int m, int n, int start, int step)
        {
            int[,] ret = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ret[i, j] = start;
                    start += step;
                }
            }
            return ret;
        }
        private static void displayMatrix(int[,] mat, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\t{0}", mat[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static int[,] calculateSpider(int[,] mat, int m, int n)
        {
            int[,] intMat;
            if (m <= 2 || n <= 2)
            {

                if (m == 2 && n == 2)
                {
                    int[,] t = new int[m, n];
                    t[0, 0] = mat[0, 0];
                    t[0, 1] = mat[0, 1];
                    t[1, 0] = mat[1, 1];
                    t[1, 1] = mat[1, 0];
                    return t;
                }
                else if (m == 2)
                {
                    int[,] t = new int[m, n];
                    for (int i = 0; i < n; i++)
                    {
                        t[0, i] = mat[0, i];
                        t[1, n - 1 - i] = mat[1, i];
                    }
                    return t;
                }
                else if (n == 2)
                {
                    int[,] t = new int[m, n];
                    int[] stMat = new int[m * n];
                    int c = 0;
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            stMat[c] = mat[i, j];
                            c++;
                        }
                    }
                    c = 0;
                    for (int i = 0; i < n; i++)
                    {
                        t[0, i] = stMat[c];
                        c++;
                    }
                    for (int i = 1; i < m; i++)
                    {
                        t[i, 1] = stMat[c];
                        c++;
                    }
                    if (m > 1) t[m - 1, 0] = stMat[c];
                    c++;
                    for (int i = m - 2; i >= 1; i--)
                    {
                        t[i, 0] = stMat[c];
                        c++;
                    }
                    return t;
                }
                else return mat;
            }
            intMat = new int[m - 2, n - 2];
            int[,] internalMatrix = new int[m - 2, n - 2]; //internal matrix
            for (int i = 0; i < ((m - 2) * (n - 2)); i++)
            {
                internalMatrix[(m - 2) - 1 - i / (n - 2), (n - 2) - 1 - i % (n - 2)] = mat[m - 1 - (i / n), n - 1 - (i % n)];
            }
            intMat = calculateSpider(internalMatrix, m - 2, n - 2);

            int[,] retMat = new int[m, n]; //return matrix
            //copy some characters to a single dimentional array
            int[] tempMat = new int[(m * n) - ((m - 2) * (n - 2))];
            for (int i = 0; i < (m * n) - ((m - 2) * (n - 2)); i++)
            {
                tempMat[i] = mat[i / n, i % n];
            }
            int count = 0;
            //copy fist row
            for (int i = 0; i < n; i++)
            {
                retMat[0, i] = tempMat[count];
                count++;
            }
            //copy last column
            for (int i = 1; i < m; i++)
            {
                retMat[i, n - 1] = tempMat[count];
                count++;
            }
            //copy last row
            for (int i = n - 2; i >= 0; i--)
            {
                retMat[m - 1, i] = tempMat[count];
                count++;
            }
            //copy first column
            for (int i = m - 2; i >= 1; i--)
            {
                retMat[i, 0] = tempMat[count];
                count++;
            }
            //copy others
            for (int i = 1; i < m - 1; i++)
            {
                for (int j = 1; j < n - 1; j++)
                {
                    retMat[i, j] = intMat[i - 1, j - 1];
                }
            }
            return retMat;
        }

    }    
}
