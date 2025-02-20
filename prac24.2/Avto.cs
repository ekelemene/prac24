using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac24._2
{
    internal class Avto
    {
        private string model;
        private string color;
        private int speed;

        public string Model
        {
            get
            {
                if (model == null || model == "") return "error";
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string Color
        {
            get
            {
                if (color == null || color == "") return "error";
                return color;
            }
            set
            {
                color = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value < 60) speed = 60;
                else if (value > 150) speed = 150;
                else speed = value;
            }
        }
        public Avto()
        {

        }

        public Avto(string model, string color, int speed)
        { 
            this.Model = model;
            this.Color = color;
            this.Speed = speed;
        }
        public string Output()
        {
            return $"model: {Model} \ncolor: {Color} \nspeed: {Speed}";
        }

    }
}
