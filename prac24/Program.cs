using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac24
{
    class Program
    {
        static void Main(string[] args)
        {
            Avto avto1 = new Avto();

            avto1.Brand = "toyota";
            avto1.Color = "red";
            avto1.Speed = 15;
            Console.WriteLine(avto1.OutPut());

            Avto avto2 = new Avto("BMV", "black", 150);
            Console.WriteLine(avto2.OutPut());

            Console.Write("Введите марку машины: ");
            string brand = Console.ReadLine();
            Console.Write("Введите цвет машины: ");
            string color = Console.ReadLine();
            Console.Write("Введите скорость машины: ");
            int speed = int.Parse(Console.ReadLine());
            Avto avto3 = new Avto(brand, color,speed);
            Console.WriteLine(avto3.OutPut());

            Console.Read();
        }
    }
}
