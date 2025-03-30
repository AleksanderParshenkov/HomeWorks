using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    public class Building
    {
        // Поля
        internal string adress;
        internal int length;
        internal int width;
        internal int height;

        // Свойства
        public string Adress {  get { return adress; } set { adress = value; } }
        public int Length { get { return length; } set { length = value; } }
        public int Width { get { return width; } set { width = value; } }
        public int Height { get { return height; } set { height = value; } }

        public Building(string adress, int length, int width, int height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print ()
        {
            Console.WriteLine($"Адрес: {Adress}\n" +
                $"Длина: {Length}\n" +
                $"Ширина: {Width}\n" +
                $"Высота: {Height}");
        }
    }

    public sealed class MultiBuilding : Building
    {
        internal int floors;
        public int Floors { get { return floors; } set { floors = value; } }

        public MultiBuilding(string adress, int length, int width, int height, int floors) : base(adress, length, width, height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
            Floors = floors;
        }

        public void Print()
        {
            base.Print();            
            Console.WriteLine($"Этажность: {Floors}");
        }
    } 
}
