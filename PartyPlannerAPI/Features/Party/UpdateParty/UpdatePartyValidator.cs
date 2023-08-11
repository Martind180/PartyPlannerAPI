using FluentValidation;
using PartyPlannerAPI.Features.Party.UpdateParty.Contracts;
using PartyPlannerAPI.Features.Party.UpdateParty.Data;

namespace PartyPlannerAPI.Features.Party.UpdateParty;

public class UpdatePartyValidator : Validator<UpdatePartyRequest>
{
    public UpdatePartyValidator()
    {
        RuleFor(r => r.PartyId)
            .NotEmpty()
            .WithMessage("PartyId is required");

        RuleFor(r => r.Party)
            .SetValidator(new UpdatePartyDtoValidator());
    }
}