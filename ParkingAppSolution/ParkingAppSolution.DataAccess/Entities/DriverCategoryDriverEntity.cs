namespace ParkingAppSolution.DataAccess.Entities;

public class DriverCategoryDriverEntity:BaseEntity
{
    public int DriverCategoryId { get; set; }
    public DriverCategoryEntity DriverCategory { get; set; }
    
    public int DriverId { get; set; }
    public DriverEntity Driver { get; set; }
}