namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50, 50].
            //Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
            //Вывести отсортированный таким образом массив на экран

            int[] array = new int[10]
                .Select(x => x = new Random().Next(-50, 50)).ToArray();

            Console.WriteLine(string.Join(',', array));

            int[] arrayStart = new int[5];
            int[] arrayEnd = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                if (i < 5) arrayStart[i] = array[i];
                else arrayEnd[i-5] = array[i];
            }

            arrayStart = arrayStart.OrderBy(x => x).ToArray();
            arrayEnd = arrayEnd.OrderByDescending(x => x).ToArray();

            for (int i = 0;i < array.Length; i++)
            {
                if (i < 5) array[i] = arrayStart[i];
                else array[i] = arrayEnd[i - 5];
            }

            Console.WriteLine(string.Join(',', array));
        }
    }
}
