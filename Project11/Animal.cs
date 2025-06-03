using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11
{
    public abstract class Animal
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public double Cost { get; set; }

        public Animal(double weight, int age, double cost)
        {
            Weight = weight;
            Age = age;
            Cost = cost;
        }

        public virtual string Info()
        {
            return "Вага: " + Weight + " кг;" +
                   "Вік: " + Age + " років;" +
                   "Вартість на добу: " + Cost + " грн;";
        }
    }

}
