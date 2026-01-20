using Labo_Agence_Voyage.Domain.Entities;

namespace Labo_Agence_Voyage.Web_API.Dtos
{
    public record ActiviterDto(Guid Id, string Nom, string Description, decimal Prix, Destination Destination)
    {}
}
