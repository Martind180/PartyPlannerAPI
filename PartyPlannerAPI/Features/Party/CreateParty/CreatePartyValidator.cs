using FluentValidation;
using PartyPlannerAPI.Features.Party.CreateParty.Contracts;
using PartyPlannerAPI.Features.Party.CreateParty.Data;

namespace PartyPlannerAPI.Features.Party.CreateParty;

public class CreatePartyValidator : Validator<CreatePartyRequest>
{
    public CreatePartyValidator()
    {
        RuleFor(x => x.Party).SetValidator(new CreatePartyDtoValidator());
        
        RuleFor(x => x.Party.Venue).SetValidator(new CreateVenueDtoValidator());
    }
}