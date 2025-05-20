using Genesis.Domain.Models;

namespace api.Domain.Models;

public partial class Vehicle : IEntity
{
  public bool? IsActive { get; set; }
  public string Plate { get; set; }
  public string Brand { get; set; }
  public string Model { get; set; }
  public int? Year { get; set; }
  public string Color { get; set; }
  public int? IdImage { get; set; }
  public int? IdUser { get; set; }
}
