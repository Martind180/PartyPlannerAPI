namespace PartyPlannerAPI.Features.Party.UpdateParty.Data;

public class UpdatePartyDtoValidator : Validator<UpdatePartyDto>
{
    public UpdatePartyDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is required");

        RuleFor(x => x.Date)
            .NotEmpty()
            .WithMessage("Date is required");
        
        RuleFor(x => x.PartyInfo)
            .NotEmpty()
            .WithMessage("PartyInfo is required");
    }
}