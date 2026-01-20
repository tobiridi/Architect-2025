namespace Labo_Agence_Voyage.Web_API.Dtos
{
    public record DestinationDto(Guid Id, string Pays, string Nom, string? Description)
    {}
}
