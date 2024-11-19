namespace ParkingAppSolution.DataAccess.Entities;

public class DriverCategoryEntity:BaseEntity
{
    public char CategorySymbol{get;set;}
    public string Description{get;set;}
    
    public List<CarTypeEntity> CarTypes{get;set;}
    public List<DriverCategoryDriverEntity> DriverCategoriesDrivers{get;set;}
}