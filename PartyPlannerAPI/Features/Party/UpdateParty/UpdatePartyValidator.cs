using FluentValidation;
using PartyPlannerAPI.Features.Party.UpdateParty.Contracts;

namespace PartyPlannerAPI.Features.Party.UpdateParty;

public class UpdatePartyValidator : Validator<UpdatePartyRequest>
{
    public UpdatePartyValidator()
    {
        RuleFor(r => r.PartyId)
            .NotEmpty()
            .WithMessage("PartyId is required");
        
        RuleFor(r => r.Party)
            .NotNull()
            .WithMessage("Party is required");
        
        RuleFor(r => r.Party.Name)
            .NotEmpty()
            .WithMessage("Party name is required");
        
        RuleFor(r => r.Party.PartyInfo)
            .NotEmpty()
            .WithMessage("Party info is required");
        
        RuleFor(r => r.Party.Date)
            .NotEmpty()
            .WithMessage("Party date is required");
    }
}