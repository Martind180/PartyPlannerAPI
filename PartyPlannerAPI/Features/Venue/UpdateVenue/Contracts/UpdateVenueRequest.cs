using PartyPlannerAPI.Features.Venue.UpdateVenue.Data;

namespace PartyPlannerAPI.Features.Venue.UpdateVenue.Contracts;

public class UpdateVenueRequest
{
    public Guid VenueId { get; set; }
    public UpdateVenueDto Venue { get; set; }
}