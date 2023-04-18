using PartyPlannerAPI.Features.Party.AddGuests.Data;

namespace PartyPlannerAPI.Features.Party.AddGuests.Contracts;

public class AddGuestsRequest
{
    public Guid PartyId { get; set; }
    public IEnumerable<GuestDto> Guests { get; set; }
}