namespace Task5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Клеточное поле размером n*n (n – константа на ваш выбор) состоит из 0 («ноликов») и 1 («крестиков»).
            //Проверить, выиграли ли «крестики»? Считается, что «крестики» выиграли, если на поле найдется горизонталь, вертикали или диагональ из «крестиков».

            // Играем в крестики-нолики, там 3х3. 1 - крестик
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[m, n];
            Random rand = new Random();
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(0,2); 
                    Console.Write(matrix[i, j]);
                }           
                Console.WriteLine();
            }
            
            Console.WriteLine(GetWin(matrix) ? "Крестики выиграли": "Крестики НЕ выиграли");
        }

        static bool GetWin(int [,] matrix)
        {
            // Проверка строк.            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool TicWinInLine = true;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0) TicWinInLine = false;
                }

                if (TicWinInLine) { Console.WriteLine("Строка"); return true; }                
            }

            // Проверка столбцов.
            bool TicWinInColumn = true;
            for (int  j = 0; j < matrix.GetLength(1); j++)
            {
                TicWinInColumn = true;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == 0) TicWinInColumn = false;
                }

                if (TicWinInColumn) { Console.WriteLine("Столбец"); return true; }
            }

            // Проверка диагоналей_диагональ 1.
            bool TicWinInDiagonal = true;
            for (int i = 0, j=0; i < matrix.GetLength(0); i++, j++)
            {
                if (matrix[i, j] == 0) TicWinInDiagonal = false;
            }
            if (TicWinInDiagonal) { Console.WriteLine("Диагональ 1"); return true; }


            // Проверка диагоналей_диагональ 2.
            TicWinInDiagonal = true;
            for (int i = matrix.GetLength(0) - 1, j = 0; i >= 0; i--, j++)
            {
                if (matrix[i, j] == 0) TicWinInDiagonal = false;
            }
            if (TicWinInDiagonal) { Console.WriteLine("Диагональ 2"); return true; }

            return false;
        }
    }
}



    
