using Microsoft.EntityFrameworkCore;
using PartyPlannerAPI.Features.Party.RemoveGuests.Contracts;
using PartyPlannerAPI.Infrastructure.Persistence;

namespace PartyPlannerAPI.Features.Party.RemoveGuests;

public class RemoveGuestsEndpoint : Endpoint<RemoveGuestsRequest>
{
    private readonly PartyPlannerDbContext _context;

    public RemoveGuestsEndpoint(PartyPlannerDbContext context)
    {
        _context = context;
    }

    public override void Configure()
    {
        //Needs to be a post request even though we are deleting as we are deleting a collection of guests
        //And a delete request does not have a body for us to post the array of guestIds
        Post("api/party/{partyId}/guests-remove");
        Description(d => d.WithDescription("Remove guests from a party"));
        AllowAnonymous();
    }

    public override async Task HandleAsync(RemoveGuestsRequest req, CancellationToken ct)
    {
        var party = await _context.Parties
            .Include(x => x.Guests)
            .FirstOrDefaultAsync(x => x.Id == req.PartyId, ct);
        
        if (party == null)
        {
            await SendNotFoundAsync(ct);
        }
        
        party.RemoveGuests(req.GuestIds);
        
        await _context.SaveChangesAsync(ct);
        await SendOkAsync(ct);
    }
}