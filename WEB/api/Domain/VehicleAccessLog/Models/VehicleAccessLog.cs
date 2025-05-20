using Genesis.Domain.Models;

namespace api.Domain.Models;

public partial class VehicleAccessLog : IEntity
{
  public bool? IsActive { get; set; }
  public System.DateTime In { get; set; }
  public System.DateTime? Out { get; set; }
  public int? IdVehicle { get; set; }
}
