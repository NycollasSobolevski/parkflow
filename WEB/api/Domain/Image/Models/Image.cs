using Genesis.Domain.Models;

namespace api.Domain.Models;

public partial class Image : IEntity
{
  public bool? IsActive { get; set; }
  public byte[] Data { get; set; }
}
