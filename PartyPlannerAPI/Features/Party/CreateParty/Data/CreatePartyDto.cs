namespace PartyPlannerAPI.Features.Party.CreateParty.Data;

public class CreatePartyDto
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string PartyInfo { get; set; }
    public CreateVenueDto Venue { get; set; }
}