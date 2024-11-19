namespace ParkingAppSolution.DataAccess.Entities;

public class DriverEntity:WorkerEntity
{
    public byte DriverExperience { get; set; }
    
    public List<CarDriverEntity> CarDrivers { get; set; }
    public List<DriverCategoryDriverEntity> DriverCategoriesDrivers { get; set; }
}