namespace PartyPlannerAPI.Features.Party.CreateParty.Data;

public class CreateVenueDto
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string Town { get; set; }
    public string County { get; set; }
    public string Postcode { get; set; }
    public string Longitude { get; set; }
    public string Latitude { get; set; }
}