namespace Domain.Models
{
    public class Film
    {
        public int Id { get; set; }
        public required string Titre { get; set; }
        public required DateTime DateSortie { get; set; }

        public override string ToString()
        {
            return "Film : { " +
                $"id : {this.Id}, " +
                $"titre : {this.Titre}, " +
                $"DateSortie : {this.DateSortie}" +
                " }";
        }
    }
}
