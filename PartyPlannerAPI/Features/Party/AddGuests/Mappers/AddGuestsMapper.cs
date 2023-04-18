using PartyPlannerAPI.Domain.Entites.Party;
using PartyPlannerAPI.Features.Party.AddGuests.Contracts;

namespace PartyPlannerAPI.Features.Party.AddGuests.Mappers;

public class AddGuestsMapper : Mapper<AddGuestsRequest, AddGuestsResponse, IEnumerable<Guest>>
{
    public override IEnumerable<Guest> ToEntity(AddGuestsRequest r) => r.Guests.Select(g => 
        new Guest(
            g.FirstName,
            g.LastName,
            g.Age,
            g.DietaryRequirement,
            g.OtherDietaryRequirement,
            g.AdditionalInformation));
}