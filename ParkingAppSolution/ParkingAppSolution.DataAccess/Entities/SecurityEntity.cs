namespace ParkingAppSolution.DataAccess.Entities;

public class SecurityEntity:WorkerEntity
{
    public byte SecurityWorkExperience { get; set; }
    
    public int WorkerId { get; set; }
    public WorkerEntity Worker { get; set; }
}