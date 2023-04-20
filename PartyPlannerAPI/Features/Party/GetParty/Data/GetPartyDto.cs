using PartyPlannerAPI.Domain.Enums;

namespace PartyPlannerAPI.Features.Party.GetParty.Data;

public class GetPartyDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string? PartyInfo { get; set; }
    public GetVenueDto Venue { get; set; }
    public IEnumerable<GetGuestDto> Guests { get; set; }
}