using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac24._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kadry kadr1 = new Kadry();
            kadr1.Surname = "Belouschenko";
            kadr1.Age = 17;
            kadr1.Dol = "student";
            kadr1.Staj = 10;
            Console.WriteLine(kadr1.Output());
            Console.WriteLine();

            Kadry kadr2 = new Kadry("Pushkin", 60, "", 60);
            Console.WriteLine(kadr2.Output());
            Console.WriteLine();
            Console.Write("surname: ");
            string surname = Console.ReadLine();
            Console.Write("age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("dol: ");
            string dol = Console.ReadLine();
            Console.Write("staj: ");
            int staj = int.Parse(Console.ReadLine());
            Kadry kadr3 = new Kadry(surname, age, dol, staj);
            Console.WriteLine(kadr3.Output());
        }
    }
}
