using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Enums;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern
{
    public class AnimalFactory
    {
        //1 approche
        //public static Animal Create(string type)
        //{
        //    switch (type.ToLower())
        //    {
        //        case "dog": return new Dog();
        //        case "cat": return new Cat();
        //        case "bird": return new Bird();
        //        default: throw new Exception($"unable to create {type}");
        //    }
        //}

        //2 approche
        //public static Animal Create(AnimalType type)
        //{
            
        //}
    }
}
