using PartyPlannerAPI.Features.Party.CreateParty.Contracts;
using PartyPlannerAPI.Features.Party.CreateParty.Mapper;
using PartyPlannerAPI.Infrastructure.Persistence;

namespace PartyPlannerAPI.Features.Party.CreateParty;

public class CreatePartyEndpoint : Endpoint<CreatePartyRequest, CreatePartyResponse, CreatePartyMapper>
{
    private readonly PartyPlannerDbContext _context;

    public CreatePartyEndpoint(PartyPlannerDbContext context)
    {
        _context = context;
    }

    public override void Configure()
    {
        Post("/api/party");
        Description(d => d.WithDescription("Create a new party"));
        //TODO: Remove once Authorization is implemented
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreatePartyRequest req, CancellationToken ct)
    {
        await _context.Parties.AddAsync(Map.ToEntity(req), ct);
        await _context.SaveChangesAsync(ct);

        await SendOkAsync(ct);
    }
}