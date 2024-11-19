namespace ParkingAppSolution.DataAccess.Entities;

public class ContractEntity:BaseEntity
{
    public int ContractNumber { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
    
    public int ParkingPlaceId { get; set; }
    public ParkingPlaceEntity ParkingPlace { get; set; }
    
    public int ClientId { get; set; }
    public ClientEntity Client { get; set; }
    
    public int CarId { get; set; }
    public CarEntity Car { get; set; }
    
    
}