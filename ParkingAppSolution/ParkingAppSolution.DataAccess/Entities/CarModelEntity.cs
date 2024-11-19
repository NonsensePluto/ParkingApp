namespace ParkingAppSolution.DataAccess.Entities;

public class CarModelEntity:BaseEntity
{
    public string Name { get; set; }
    
    public int CarMarkId { get; set; }
    public CarMarkEntity CarMark { get; set; }
}