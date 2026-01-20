using Labo_Agence_Voyage.Domain.Entities;

namespace Labo_Agence_Voyage.Web_API.Dtos
{
    public record ReservationDto(Guid Id, string NomClient, DateTime DateReservation, Destination Destination)
    {}
}
