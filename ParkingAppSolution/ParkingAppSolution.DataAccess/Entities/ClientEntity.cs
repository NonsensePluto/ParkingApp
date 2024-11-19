namespace ParkingAppSolution.DataAccess.Entities;

public class ClientEntity : BaseEntity
{
    public string? PhoneNumber { get; set; }
    public byte PersonalSale { get; set; }
    
    public int PasportNumber { get; set; }
    public PasportEntity Pasport { get; set; }
    
    public List<ContractEntity> Contracts { get; set; }
    
}