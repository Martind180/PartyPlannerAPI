using PartyPlannerAPI.Features.Party.UpdateGuest.Data;

namespace PartyPlannerAPI.Features.Party.UpdateGuest.Contracts;

public class UpdateGuestRequest
{
    public Guid GuestId { get; set; }
    public UpdateGuestDto Guest { get; set; }
}