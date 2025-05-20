using Genesis.Domain.Models;

namespace api.Domain.Models;

public partial class Plan : IEntity
{
  public bool? IsActive { get; set; }
  public int Plan { get; set; }
  public string Title { get; set; }
  public string Description { get; set; }
  public decimal? Price { get; set; }
}
