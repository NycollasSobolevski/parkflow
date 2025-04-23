using Genesis.Domain.Models;

namespace api.Domain.Models;

public partial class Company : IEntity
{
  public bool? IsActive { get; set; }
  public string Name { get; set; }
  public string Cnpj { get; set; }
  public int? IdAddress { get; set; }
  public int? IdPlan { get; set; }
  public int? IdSettings { get; set; }
}
