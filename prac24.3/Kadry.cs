using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac24._3
{
    internal class Kadry
    {
        private string surname;
        private int age;
        private string dol;
        private int staj;

        public Kadry()
        {

        }

        public Kadry(string surname, int age, string dol, int staj)
        {
            this.Surname = surname;
            this.Age = age;
            this.Dol = dol;
            this.Staj = staj;
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value == null || value == "" ? "error" : value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 16) age = 16;
                else if (value > 60) age = 60;  
                else age = value;
            }
        }
        public string Dol
        {
            get
            {
                return dol;
            }
            set
            {
                dol = value == null || value == "" ? "error" : value;
            }
        }
        public int Staj
        {
            get
            {
                return staj;
            }
            set
            {
                if (value < 0) staj = 0;
                else if (value > 45) staj = 45;
                else staj = value;
            }
        }

         public string Output()
        {
            return $"surname: {Surname} \nage: {Age} \ndol: {Dol} \nstaj: {Staj}";
        }


    }
}
