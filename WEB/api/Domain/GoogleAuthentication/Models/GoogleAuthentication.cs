using Genesis.Domain.Models;

namespace api.Domain.Models;

public partial class GoogleAuthentication : IEntity
{
  public bool? IsActive { get; set; }
  public string Token { get; set; }
  public int? IdUser { get; set; }
}
