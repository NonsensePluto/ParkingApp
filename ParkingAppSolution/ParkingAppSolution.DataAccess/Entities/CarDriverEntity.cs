namespace ParkingAppSolution.DataAccess.Entities;

public class CarDriverEntity: BaseEntity
{
    public DateTime DeliveryDate { get; set; }
    public string Address { get; set; }
    
    public int CarId { get; set; }
    public CarEntity Car { get; set; }
    
    public int DriverId { get; set; }
    public DriverEntity Driver { get; set; }
}