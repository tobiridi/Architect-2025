using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__reminder.Classes
{
    internal class Human
    {
        private string Name {  get; set; }
        private int Age { get; set; }

        public Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            
        }
    }
}
