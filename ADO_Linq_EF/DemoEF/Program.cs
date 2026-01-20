using DAL.Database;
using Domain.Enums;
using Domain.Models;

namespace DemoEF
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (DbContextDemo DbCtx = new DbContextDemo())
            {
                Console.WriteLine("Je suis connecté!");

                //Car car1 = new Car(100, CarState.FOR_PARTS)
                //{ Model = "Polo"};

                //insert
                //DbCtx.CarsSet.Add(car1);
                //DbCtx.SaveChanges();

                //select
                List<Car> cars = DbCtx.CarsSet.ToList();
                cars.ForEach(car => Console.WriteLine(car));

                //update
                //cars[0].State = CarState.FOR_PARTS;
                //DbCtx.SaveChanges();

                //delete
                //DbCtx.Remove(cars[0]);
                //DbCtx.SaveChanges();
            }
        }
    }
}
