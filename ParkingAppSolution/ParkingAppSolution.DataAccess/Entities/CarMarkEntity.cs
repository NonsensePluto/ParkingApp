namespace ParkingAppSolution.DataAccess.Entities;

public class CarMarkEntity:BaseEntity
{
    public string Name{get;set;}
    
    public List<CarModelEntity> CarModels{ get; set; }
    public List<CarEntity> Cars{ get; set; }
}