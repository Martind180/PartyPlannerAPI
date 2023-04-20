using PartyPlannerAPI.Domain.Enums;
using PartyPlannerAPI.Features.Party.GetParty.Contracts;
using PartyPlannerAPI.Features.Party.GetParty.Data;

namespace PartyPlannerAPI.Features.Party.GetParty.Mapper;

public class GetPartyMapper : Mapper<GetPartyRequest, GetPartyResponse, Domain.Entites.Party.Party>
{
    public override GetPartyResponse FromEntity(Domain.Entites.Party.Party e) => new GetPartyResponse
    {
        Party = new GetPartyDto
        {
            Id = e.Id,
            Name = e.Name,
            Date = e.Date,
            PartyInfo = e.PartyInfo,
            Venue = new GetVenueDto
            {
                Id = e.Venue.Id,
                Name = e.Venue.Name,
                Description = e.Venue.Description,
                AddressLine1 = e.Venue.AddressLine1,
                AddressLine2 = e.Venue.AddressLine2,
                Town = e.Venue.Town,
                County = e.Venue.County,
                Postcode = e.Venue.Postcode,
                Longitude = e.Venue.Longitude,
                Latitude = e.Venue.Latitude
            },
            Guests = e.Guests.Select(g => new GetGuestDto
            {
                Id = g.Id,
                FirstName = g.FirstName,
                LastName = g.LastName,
                Age = g.Age,
                DietaryRequirement = g.DietaryRequirement,
                OtherDietaryRequirement = g.OtherDietaryRequirement,
                AdditionalInformation = g.AdditionalInformation
            }),

        }
    };
}