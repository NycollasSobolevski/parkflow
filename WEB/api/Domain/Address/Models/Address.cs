using Genesis.Domain.Models;

namespace api.Domain.Models;

public partial class Address : IEntity
{
  public bool? IsActive { get; set; }
  public string Cep { get; set; }
  public string Country { get; set; }
  public string State { get; set; }
  public string City { get; set; }
  public string Neighborhood { get; set; }
  public string Street { get; set; }
  public int Number { get; set; }
}
