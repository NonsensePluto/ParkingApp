using System.ComponentModel.DataAnnotations;

namespace ParkingAppSolution.DataAccess.Entities;

public class ParkingEntity : BaseEntity
{
    public string ParkingName { get; set; }
    public string Address { get; set; }
    public int Capacity { get; set; }
    
    public int ParkingTypeId { get; set; }
    public ParkingTypeEntity ParkingType { get; set; }
    
    public List<ParkingPlaceEntity> ParkingPlaces { get; set; }
    public List<WorkerEntity> Employers { get; set; }

}