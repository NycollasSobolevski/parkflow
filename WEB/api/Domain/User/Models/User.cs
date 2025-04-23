using Genesis.Domain.Models;

namespace api.Domain.Models;

public partial class User : IEntity
{
  public bool? IsActive { get; set; }
  public string Name { get; set; }
  public string Document { get; set; }
  public string Email { get; set; }
  public string Hash { get; set; }
  public string Phone { get; set; }
  public int? IdAddress { get; set; }
  public int? IdRole { get; set; }
  public int? IdImage { get; set; }
  public int? IdCompany { get; set; }
}
