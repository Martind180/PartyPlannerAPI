using PartyPlannerAPI.Features.Party.CreateParty.Data;

namespace PartyPlannerAPI.Features.Party.CreateParty.Contracts;

public class CreatePartyRequest
{
    public CreatePartyDto Party { get; set; }
}