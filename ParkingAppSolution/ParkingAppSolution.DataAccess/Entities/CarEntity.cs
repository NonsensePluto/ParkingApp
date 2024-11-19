namespace ParkingAppSolution.DataAccess.Entities;

public class CarEntity:BaseEntity
{
    public int ReleaseYear { get; set; }
    public string CarNumber { get; set; }
    
    public int CarTypeId { get; set; }
    public CarTypeEntity CarType { get; set; }
    
    public int CarMarkId { get; set; }
    public CarMarkEntity CarMark { get; set; }
    
    public List<CarDriverEntity> CarDrivers { get; set; }
    public List<ContractEntity> Contracts { get; set; }
}