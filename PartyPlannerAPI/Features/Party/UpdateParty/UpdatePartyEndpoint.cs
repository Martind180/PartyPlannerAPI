using PartyPlannerAPI.Features.Party.UpdateParty.Contracts;
using PartyPlannerAPI.Infrastructure.Persistence;

namespace PartyPlannerAPI.Features.Party.UpdateParty;

public class UpdatePartyEndpoint : Endpoint<UpdatePartyRequest>
{
    private readonly PartyPlannerDbContext _context;

    public UpdatePartyEndpoint(PartyPlannerDbContext context)
    {
        _context = context;
    }

    public override void Configure()
    {
        Put("api/party/{PartyId}");
        Description(d => d.WithDescription("Updates a Party"));
        AllowAnonymous();
    }

    public override async Task HandleAsync(UpdatePartyRequest req, CancellationToken ct)
    {
        var party = await _context.Parties.FindAsync(new object?[] { req.PartyId }, cancellationToken: ct);

        if (party == null)
            await SendNotFoundAsync(ct);
        
        party.Name = req.Party.Name;
        party.PartyInfo = req.Party.PartyInfo;
        party.Date = req.Party.Date;

        await _context.SaveChangesAsync(ct);

        await SendOkAsync(ct);
    }
}