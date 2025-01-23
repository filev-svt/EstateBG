namespace api.Models;

public class ResidentialProperty
{
    public int Id { get; set; }
    public decimal? Price { get; set; }
    public short? YearBuilt { get; set; }
    public short FloorsCount { get; set; }
    public short RoomsCount { get; set; }
    public short BathroomsCount { get; set; }
    public short GaragesCount { get; set; }
    public short ParkingSpacesCount { get; set; }
    public decimal FloorArea { get; set; }
    public decimal LotArea { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? PublishedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public string? EnergyEfficiencyRating { get; set; }

}