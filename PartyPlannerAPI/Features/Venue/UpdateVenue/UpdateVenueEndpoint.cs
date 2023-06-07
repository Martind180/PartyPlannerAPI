using Microsoft.EntityFrameworkCore;
using PartyPlannerAPI.Features.Venue.UpdateVenue.Contracts;
using PartyPlannerAPI.Features.Venue.UpdateVenue.Mapper;
using PartyPlannerAPI.Infrastructure.Persistence;

namespace PartyPlannerAPI.Features.Venue.UpdateVenue;

public class UpdateVenueEndpoint : Endpoint<UpdateVenueRequest, UpdateVenueResponse, UpdateVenueMapper>
{
    private readonly PartyPlannerDbContext _context;

    public UpdateVenueEndpoint(PartyPlannerDbContext context)
    {
        _context = context;
    }

    public override void Configure()
    {
        Put("/api/venues/{venueId}");
        Description(d => d.WithDescription("Update a venue"));
        AllowAnonymous();
    }

    public override async Task HandleAsync(UpdateVenueRequest req, CancellationToken ct)
    {
        var venue = await _context.Venues.AsNoTracking().FirstOrDefaultAsync(v => v.Id == req.VenueId, ct);

        if (venue is null)
            await SendNotFoundAsync(ct);
        
        _context.Venues.Update(Map.ToEntity(req));
        await _context.SaveChangesAsync(ct);
        
        await SendOkAsync(ct);
    }
}