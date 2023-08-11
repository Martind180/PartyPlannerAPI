namespace PartyPlannerAPI.Features.Party.CreateParty.Data;

public class CreateVenueDtoValidator : Validator<CreateVenueDto>
{
    public CreateVenueDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Venue name cannot be empty");
        
        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage("Venue description cannot be empty");
        
        RuleFor(x => x.AddressLine1)
            .NotEmpty()
            .WithMessage("Venue address line 1 cannot be empty");
        
        RuleFor(x => x.Town)
            .NotEmpty()
            .WithMessage("Venue town cannot be empty");
            
        RuleFor(x => x.County)
            .NotEmpty()
            .WithMessage("Venue county cannot be empty");
        
        RuleFor(x => x.Postcode)
            .NotEmpty()
            .WithMessage("Venue postcode cannot be empty");
            
        RuleFor(x => x.Longitude)
            .NotEmpty()
            .WithMessage("Venue longitude cannot be empty");
        
        RuleFor(x => x.Latitude)
            .NotEmpty()
            .WithMessage("Venue latitude cannot be empty");
    }
}