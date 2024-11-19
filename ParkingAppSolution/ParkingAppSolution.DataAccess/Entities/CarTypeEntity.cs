namespace ParkingAppSolution.DataAccess.Entities;

public class CarTypeEntity:BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    public int DriverCategoryId { get; set; }
    public DriverCategoryEntity DriverCategory { get; set; }
    
    public List<CarEntity> Cars { get; set; }
}