namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать двумерный массив вида
            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1

            int[] array1 = new int[5] { 1, 0, 1, 0, 1 };
            int[] array2 = new int[5] { 0, 1, 0, 1, 0 };

            int[][] array = new int[5][] {array1, array2, array1, array2, array1};

            foreach (int [] item in array)
            {
                Console.WriteLine(string.Join(' ', item));
            }
                      
        }
    }
}
