using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac24._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto avto1 = new Avto();
            Console.WriteLine(avto1.Output());
            Console.WriteLine();

            Avto avto2 = new Avto("BMV","red",140);
            Console.WriteLine(avto2.Output());
            Console.WriteLine();

            Avto avto3 = new Avto("mers", "" , 50);
            Console.WriteLine(avto3.Output());
            Console.WriteLine();
            Console.Write("model: ");
            string model1 = Console.ReadLine();
            Console.Write("color: ");
            string color1 = Console.ReadLine();
            Console.Write("speed: ");
            int speed1 = int.Parse(Console.ReadLine());
            Avto avto4 = new Avto(model1,color1,speed1);
            Console.WriteLine(avto4.Output());
        }
    }
}
