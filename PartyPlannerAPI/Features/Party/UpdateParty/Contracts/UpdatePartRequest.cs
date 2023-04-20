using PartyPlannerAPI.Features.Party.UpdateParty.Data;

namespace PartyPlannerAPI.Features.Party.UpdateParty.Contracts;

public class UpdatePartRequest
{
    public Guid PartyId { get; set; }
    public UpdatePartyDto Party { get; set; }
}