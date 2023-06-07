using FluentValidation;
using PartyPlannerAPI.Features.Party.CreateParty.Contracts;

namespace PartyPlannerAPI.Features.Party.CreateParty;

public class CreatePartyValidator : Validator<CreatePartyRequest>
{
    public CreatePartyValidator()
    {
        RuleFor(x => x.Party.Name)
            .NotEmpty()
            .WithMessage("Party name cannot be empty");
        
        RuleFor(x => x.Party.PartyInfo)
            .NotEmpty()
            .WithMessage("Party info cannot be empty");
        
        RuleFor(x => x.Party.Date)
            .NotNull()
            .WithMessage("Party date cannot be empty");

        RuleFor(x => x.Party.Venue)
            .NotNull()
            .WithMessage("Please provide a venue");
        
        //Venue validation
        RuleFor(x => x.Party.Venue.Name)
            .NotEmpty()
            .WithMessage("Venue name cannot be empty");
        
        RuleFor(x => x.Party.Venue.Description)
            .NotEmpty()
            .WithMessage("Venue description cannot be empty");
        
        RuleFor(x => x.Party.Venue.AddressLine1)
            .NotEmpty()
            .WithMessage("Venue address line 1 cannot be empty");
        
        RuleFor(x => x.Party.Venue.Town)
            .NotEmpty()
            .WithMessage("Venue town cannot be empty");
            
        RuleFor(x => x.Party.Venue.County)
            .NotEmpty()
            .WithMessage("Venue county cannot be empty");
        
        RuleFor(x => x.Party.Venue.Postcode)
            .NotEmpty()
            .WithMessage("Venue postcode cannot be empty");
            
        RuleFor(x => x.Party.Venue.Longitude)
            .NotEmpty()
            .WithMessage("Venue longitude cannot be empty");
        
        RuleFor(x => x.Party.Venue.Latitude)
            .NotEmpty()
            .WithMessage("Venue latitude cannot be empty");
    }
}