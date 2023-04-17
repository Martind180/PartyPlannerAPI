namespace PartyPlannerAPI.Domain.Entites.Party;

public class Venue
{
    public Venue() { }

    public Venue(
        string name,
        string? description,
        string addressLine1,
        string? addressLine2,
        string town,
        string county,
        string postcode,
        string longitude,
        string latitude)
    {
        Name = name;
        Description = description;
        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
        Town = town;
        County = county;
        Postcode = postcode;
        Longitude = longitude;
        Latitude = latitude;
    }
    
    public Guid Id { get; set; }
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