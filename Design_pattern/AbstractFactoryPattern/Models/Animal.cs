using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Models
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal()
        {
            Name = "Unamed";
        }

        public Animal(string name)
        {
            Name = name;
        }
    }
}
