namespace api.Models;

public class House : Listing
{
    public short YearBuilt { get; set; }
    public short FloorsCount { get; set; }
    public short RoomsCount { get; set; }
    public short BathroomsCount { get; set; }
    public short GaragesCount { get; set; }
    public short ParkingSpacesCount { get; set; }
    public decimal FloorArea { get; set; }
    public decimal LotArea { get; set; }

}