namespace ParkingAppSolution.DataAccess.Entities;

public class ParkingPlaceEntity:BaseEntity
{
    public int PlaceNumber { get; set; }
    public bool IsReserved { get; set; }
    
    public int ParkingId { get; set; }
    public ParkingEntity Parking { get; set; }
    
    public int ParkingPlaceTypeId { get; set; }
    public ParkingPlaceTypeEntity ParkingPlaceType { get; set; }
    
    public List<ContractEntity> Contracts { get; set; }
}