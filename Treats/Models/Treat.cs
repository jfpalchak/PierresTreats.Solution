
namespace Pierres.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Type { get; set; }

    public List<TreatFlavor> JoinEntities { get; set; }
  }
}