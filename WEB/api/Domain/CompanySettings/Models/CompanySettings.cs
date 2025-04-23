using Genesis.Domain.Models;

namespace api.Domain.Models;

public partial class CompanySettings : IEntity
{
  public bool? IsActive { get; set; }
  public int? VehiclePerUser { get; set; }
}
