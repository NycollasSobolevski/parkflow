using Genesis.Domain.Models;

namespace api.Domain.Models;

public partial class Role : IEntity
{
  public bool? IsActive { get; set; }
  public int Role { get; set; }
}
