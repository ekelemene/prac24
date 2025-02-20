using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac24
{
    class Avto
    { 
        //поля
        private string brand;
        private string color;
        private double speed;
        //конструктор без параметров

        public Avto()
        {

        } 
        //конструктор с 3 параметрами 
        public Avto(string brand1, string color1, double speed1)
        {
            this.Brand = brand1;
            this.Color = color1;
            this.Speed = speed1;
        }
        //свойства без валидации
        public string Brand { get { return brand; } set { brand = value; } }
        public string Color { get { return color; } set {color = value; } }

        //свойство speed с валидацией для проверки данных
        public double Speed 
        { 
            get { return speed; } 
            set { 
                if (value < 20) speed = 20; 
                else if (value > 120) speed = 120;
                else speed = value; }  }

        //метод вывода
        public string OutPut()
        {
            return $"\n brand = {brand} \n color = {color} \n speed = {speed}";
        }
    }
}
