namespace ParkingAppSolution.DataAccess.Entities;

public class ParkingTypeEntity:BaseEntity
{
    
    public string Description { get; set; }
    
    public List<ParkingEntity> Parkings { get; set; }
}