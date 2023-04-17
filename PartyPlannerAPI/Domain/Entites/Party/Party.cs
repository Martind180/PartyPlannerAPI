namespace PartyPlannerAPI.Domain.Entites.Party;

public class Party
{
    public Party() { }
    
    public Party(string name, DateTime date, string partyInfo, Venue venue, IEnumerable<Guest>? guests)
    {
        Name = name;
        Date = date;
        PartyInfo = partyInfo;
        Venue = venue;
        
        if (guests != null)
        {
            _guests.AddRange(guests);
        }
    }
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string PartyInfo { get; set; }
    public Guid VenueId { get; set; }
    public Venue Venue { get; set; }
    
    
    private readonly List<Guest> _guests = new();
    public IReadOnlyCollection<Guest> Guests => _guests.AsReadOnly();
    
    public void AddGuest(Guest guest)
    {
        _guests.Add(guest);
    }
}