namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задан класс Building, который описывает здание. Класс содержит следующие элементы:
            //  адрес здания;
            //  длина здания;
            //  ширина здания;
            //  высота здания.

            // В классе Building нужно реализовать следующие методы:
            //  конструктор с 4 параметрами;
            //  свойства get/ set для доступа к полям класса;
            //  метод Print(), который выводит информацию о здании.

            // Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.

            // В классе MultiBuilding реализовать следующие элементы:
            //  конструктор с 5 параметрами – реализует вызов конструктора базового класса;
            //  свойство get/ set доступа к внутреннему полю класса;
            //  метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.

            // Класс MultiBuilding сделать таким, что не может быть унаследован.

            // Точка входа тут, а сами классы в классе Building
            Building building = new Building("Voronezh", 15, 25, 35);
            building.Print();

            Console.WriteLine();
            Console.WriteLine("***");
            Console.WriteLine();

            MultiBuilding multiBuilding = new MultiBuilding("Sinye Lipyagi", 15, 25, 35, 10);
            multiBuilding.Print();

            Console.ReadKey();
        }
    }
}
