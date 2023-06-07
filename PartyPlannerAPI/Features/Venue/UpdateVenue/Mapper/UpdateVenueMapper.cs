using PartyPlannerAPI.Features.Venue.UpdateVenue.Contracts;

namespace PartyPlannerAPI.Features.Venue.UpdateVenue.Mapper;

public class UpdateVenueMapper : Mapper<UpdateVenueRequest, UpdateVenueResponse, Domain.Entites.Party.Venue>
{
    public override Domain.Entites.Party.Venue ToEntity(UpdateVenueRequest r) => new()
    {
        Id = r.VenueId,
        Name = r.Venue.Name,
        Description = r.Venue.Description,
        AddressLine1 = r.Venue.AddressLine1,
        AddressLine2 = r.Venue.AddressLine2,
        Town = r.Venue.Town,
        County = r.Venue.County,
        Postcode = r.Venue.Postcode,
        Longitude = r.Venue.Longitude,
        Latitude = r.Venue.Latitude
    };
}