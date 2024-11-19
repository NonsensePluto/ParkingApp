namespace ParkingAppSolution.DataAccess.Entities;

public class PasportEntity : BaseEntity
{
    public int Number { get; set; }
    public int Seria { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public string? Patronymic { get; set; }
    
    public List<ClientEntity> Clients { get; set; }
    public List<WorkerEntity> Workers { get; set; }

}