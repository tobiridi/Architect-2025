using Domain.Enums;

namespace Domain.Models
{
    public class Car
    {
        public int Id { get; set; }
        public required string Model { get; set; }
        public decimal Price { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public CarState State { get; set; }

        public Car(decimal price, CarState state)
        {
            this.Price = price;
            this.RegistrationDate = DateTime.Now;
            this.State = state;
        }

        public override string ToString()
        {
            return $"Car : [id={this.Id} |" +
                $"model={this.Model} |" +
                $"price={this.Price} |" +
                $"registration={this.RegistrationDate} |" +
                $"state={this.State}]";
        }
    }
}
