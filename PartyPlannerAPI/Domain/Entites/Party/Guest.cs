using PartyPlannerAPI.Domain.Enums;

namespace PartyPlannerAPI.Domain.Entites.Party;

public class Guest
{
    public Guest() { }

    public Guest(
        string firstName,
        string lastName,
        int age,
        DietaryRequirements dietaryRequirement,
        string? otherDietaryRequirement,
        string? additionalInformation)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        DietaryRequirement = dietaryRequirement;
        OtherDietaryRequirement = otherDietaryRequirement;
        AdditionalInformation = additionalInformation;
    }

    public Guid Id { get; set; }
    public Guid PartyId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DietaryRequirements DietaryRequirement { get; set; }
    public string? OtherDietaryRequirement { get; set; }
    public string? AdditionalInformation { get; set; }
}