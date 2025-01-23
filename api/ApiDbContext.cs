using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api;

public class ApiDbContext : DbContext {
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

    public DbSet<House> Houses { get; set; }
    public DbSet<Apartment> Apartments { get; set; }
    public DbSet<ResidentialProperty> ResidentialProperties { get; set; }
    
}