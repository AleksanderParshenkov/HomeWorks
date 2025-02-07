namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится строка "a=1, b=2, c=3"

            var ints = Console.ReadLine()?
                .ToList()
                .Where(x => char.IsDigit(x))
                .Select(x => Int32.Parse(x.ToString()))
                .ToList();

            var result = new List<int>() { ints[ints.Count - 1] };
            ints.RemoveAt(ints.Count - 1);
            foreach (var item in ints) {result.Add(item); }

            Console.WriteLine(string.Join(",", result));
            Console.ReadLine();
        }
    }
}
