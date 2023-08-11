namespace PartyPlannerAPI.Features.Party.CreateParty.Data;

public class CreatePartyDtoValidator : Validator<CreatePartyDto>
{
    public CreatePartyDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Party name cannot be empty");
        
        RuleFor(x => x.PartyInfo)
            .NotEmpty()
            .WithMessage("Party info cannot be empty");
        
        RuleFor(x => x.Date)
            .NotNull()
            .WithMessage("Party date cannot be empty");

        RuleFor(x => x.Venue)
            .NotNull()
            .WithMessage("Please provide a venue");
    }
}