using PartyPlannerAPI.Features.Party.AddGuests.Contracts;
using PartyPlannerAPI.Features.Party.AddGuests.Mappers;
using PartyPlannerAPI.Infrastructure.Persistence;

namespace PartyPlannerAPI.Features.Party.AddGuests;

public class AddGuestsEndpoint : Endpoint<AddGuestsRequest, AddGuestsResponse, AddGuestsMapper>
{
    private readonly PartyPlannerDbContext _context;

    public AddGuestsEndpoint(PartyPlannerDbContext context)
    {
        _context = context;
    }

    public override void Configure()
    {
        Post("/api/party/{partyId}/guests");
        Description(d => d.WithDescription("Add guests to a party"));
        AllowAnonymous();
    }

    public override async Task HandleAsync(AddGuestsRequest req, CancellationToken ct)
    {
        var party = await _context.Parties.FindAsync(new object?[] { req.PartyId }, ct);
        
        if (party == null)
        {
            await SendNotFoundAsync(ct);
        }
        
        party.AddGuests(Map.ToEntity(req));
        await _context.SaveChangesAsync(ct);
        
        await SendOkAsync(ct);
    }
}