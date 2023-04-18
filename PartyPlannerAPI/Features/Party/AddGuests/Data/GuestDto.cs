using PartyPlannerAPI.Domain.Enums;

namespace PartyPlannerAPI.Features.Party.AddGuests.Data;

public class GuestDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DietaryRequirements DietaryRequirement { get; set; }
    public string? OtherDietaryRequirement { get; set; }
    public string? AdditionalInformation { get; set; }
}