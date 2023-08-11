using PartyPlannerAPI.Features.Party.AddGuests.Contracts;
using PartyPlannerAPI.Features.Party.AddGuests.Data;

namespace PartyPlannerAPI.Features.Party.AddGuests;

public class AddGuestsValidator : Validator<AddGuestsRequest>
{
    public AddGuestsValidator()
    {
        RuleFor(x => x.PartyId)
            .NotNull()
            .WithMessage("PartyId can not be null");
        
        RuleFor(x => x.Guests)
            .NotEmpty()
            .WithMessage("Guests can not be empty");

        RuleForEach(x => x.Guests)
            .SetValidator(new GuestDtoValidator());
    }
}