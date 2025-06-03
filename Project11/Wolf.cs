using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11
{
    public class Wolf : Animal
    {
        public string Breed { get; set; }
        public string Location { get; set; }

        public Wolf(double weight, int age, double cost, string breed, string location)
            : base(weight, age, cost)
        {
            Breed = breed;
            Location = location;
        }

        public override string Info()
        {
            return base.Info() +
                   "Порода: " + Breed + ";" +
                   "Локація: " + Location + ";";
        }
    }

}
