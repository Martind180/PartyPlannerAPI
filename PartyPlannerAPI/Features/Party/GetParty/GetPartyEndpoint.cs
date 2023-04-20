using Microsoft.EntityFrameworkCore;
using PartyPlannerAPI.Features.Party.GetParty.Contracts;
using PartyPlannerAPI.Features.Party.GetParty.Mapper;
using PartyPlannerAPI.Infrastructure.Persistence;

namespace PartyPlannerAPI.Features.Party.GetParty;

public class GetPartyEndpoint : Endpoint<GetPartyRequest, GetPartyResponse, GetPartyMapper>
{
    private readonly PartyPlannerDbContext _context;

    public GetPartyEndpoint(PartyPlannerDbContext context)
    {
        _context = context;
    }

    public override void Configure()
    {
        Get("/api/party/{id}");
        Description(d => d.WithDescription("Get a party"));
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetPartyRequest req, CancellationToken ct)
    {
        var party = await _context.Parties
            .Include(p => p.Guests)
            .Include(p => p.Venue)
            .FirstOrDefaultAsync(p => p.Id == req.PartyId, ct);
        
        if (party == null)
        {
            await SendNotFoundAsync(ct);
        }

        await SendOkAsync(Map.FromEntity(party), ct);
    }
}