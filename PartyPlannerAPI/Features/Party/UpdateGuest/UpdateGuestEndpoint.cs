using PartyPlannerAPI.Features.Party.UpdateGuest.Contracts;
using PartyPlannerAPI.Infrastructure.Persistence;

namespace PartyPlannerAPI.Features.Party.UpdateGuest;

public class UpdateGuestEndpoint : Endpoint<UpdateGuestRequest>
{
    private readonly PartyPlannerDbContext _context;

    public UpdateGuestEndpoint(PartyPlannerDbContext context)
    {
        _context = context;
    }

    public override void Configure()
    {
        Put("/api/party/guest/{GuestId}");
        Description(d => d.WithDescription("Update a guest"));
        AllowAnonymous();
    }

    public override async Task HandleAsync(UpdateGuestRequest req, CancellationToken ct)
    {
        var guest = await _context.Guests.FindAsync(new object?[] { req.GuestId }, cancellationToken: ct);

        if (guest == null)
        {
            await SendNotFoundAsync(ct);
        }

        //TODO: Potentially include mapster/automapper for the cleaner mapping of properties to existing objects
        guest.FirstName = req.Guest.FirstName;
        guest.LastName = req.Guest.LastName;
        guest.Age = req.Guest.Age;
        guest.DietaryRequirement = req.Guest.DietaryRequirement;
        guest.OtherDietaryRequirement = req.Guest.OtherDietaryRequirement;
        guest.AdditionalInformation = req.Guest.AdditionalInformation;
        
        await _context.SaveChangesAsync(ct);

        await SendOkAsync(ct);
    }
}