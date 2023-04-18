namespace PartyPlannerAPI.Features.Party.RemoveGuests.Contracts;

public class RemoveGuestsRequest
{
    public Guid PartyId { get; set; }
    public IEnumerable<Guid> GuestIds { get; set; }
}