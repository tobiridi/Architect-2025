using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Models
{
    public class Dog : Animal, IScreamable
    {
        public void Scream()
        {
            Console.WriteLine("wouf!");
        }
    }
}
