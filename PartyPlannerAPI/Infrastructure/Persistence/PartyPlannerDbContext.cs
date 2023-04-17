using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PartyPlannerAPI.Domain.Entites.Party;

namespace PartyPlannerAPI.Infrastructure.Persistence;

public class PartyPlannerDbContext: DbContext
{
    public PartyPlannerDbContext(DbContextOptions<PartyPlannerDbContext> options) : base(options) { }

    public DbSet<Party> Parties { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Venue> Venues { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}