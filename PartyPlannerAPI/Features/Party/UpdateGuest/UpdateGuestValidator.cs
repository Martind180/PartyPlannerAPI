using PartyPlannerAPI.Features.Party.UpdateGuest.Contracts;
using PartyPlannerAPI.Features.Party.UpdateGuest.Data;

namespace PartyPlannerAPI.Features.Party.UpdateGuest;

public class UpdateGuestValidator : Validator<UpdateGuestRequest>
{
    public UpdateGuestValidator()
    {
        RuleFor(x => x.GuestId)
            .NotEmpty()
            .WithMessage("GuestId is required");

        RuleFor(x => x.Guest)
            .SetValidator(new UpdateGuestDtoValidator());
    }
}