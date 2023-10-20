using System.Collections.Generic;

namespace Pierres.Models
{
  public class Flavor 
  {
    public int FlavorId { get; set; }
    public string Type { get; set; }

    public List<TreatFlavor> JoinEntities { get; set; }
  }
}