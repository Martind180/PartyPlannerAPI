using PartyPlannerAPI.Domain.Entites.Party;
using PartyPlannerAPI.Features.Party.CreateParty.Contracts;

namespace PartyPlannerAPI.Features.Party.CreateParty.Mapper;

public class CreatePartyMapper : Mapper<CreatePartyRequest, CreatePartyResponse, Domain.Entites.Party.Party>
{
    public override Domain.Entites.Party.Party ToEntity(CreatePartyRequest r) => new()
    {
        Name = r.Party.Name,
        Date = r.Party.Date,
        PartyInfo = r.Party.PartyInfo,
        Venue = new Domain.Entites.Party.Venue(
            r.Party.Venue.Name,
            r.Party.Venue.Description,
            r.Party.Venue.AddressLine1,
            r.Party.Venue.AddressLine2,
            r.Party.Venue.Town,
            r.Party.Venue.County,
            r.Party.Venue.Postcode,
            r.Party.Venue.Longitude,
            r.Party.Venue.Latitude)
    };
    }