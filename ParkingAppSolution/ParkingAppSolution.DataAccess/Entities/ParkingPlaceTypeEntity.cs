namespace ParkingAppSolution.DataAccess.Entities;

public class ParkingPlaceTypeEntity:BaseEntity
{
    public int PlaceWidth { get; set; }
    public int PlaceLenght { get; set; }
    public decimal? Price { get; set; }
    
    public List<ParkingPlaceEntity> ParkingPlaces { get; set; }
}