namespace ParkingAppSolution.DataAccess.Entities;

public class WorkerEntity:BaseEntity
{
    public string PhoneNumber { get; set; }
    public decimal Salary { get; set; }
    public byte WorkExperience { get; set; }
    
    public int PasportNumber { get; set; }
    public PasportEntity Pasport { get; set; }
    
    public int ParkingId { get; set; }
    public ParkingEntity Parking { get; set; }
    
    public DriverEntity Driver { get; set; }
    
    public SecurityEntity Security { get; set; }
}