using PartyPlannerAPI.Domain.Enums;

namespace PartyPlannerAPI.Features.Party.UpdateGuest.Data;

public class UpdateGuestDtoValidator : Validator<UpdateGuestDto>
{
    public UpdateGuestDtoValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage("FirstName is required")
            .MaximumLength(15)
            .WithMessage("FirstName must be less than 15 characters");
        
        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("LastName is required")
            .MaximumLength(15)
            .WithMessage("LastName must be less than 15 characters");
        
        RuleFor(x => x.Age)
            .NotEmpty()
            .WithMessage("Age is required");

        RuleFor(x => x.DietaryRequirement)
            .NotEmpty()
            .WithMessage("DietaryRequirement is required");

        When(x => x.DietaryRequirement == DietaryRequirements.Other, () =>
        {
            RuleFor(x => x.OtherDietaryRequirement)
                .NotEmpty()
                .WithMessage(
                    "OtherDietaryRequirement is required when DietaryRequirement == DietaryRequirements.Other");
        });
    }
}