using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pierres.Models
{
  public class Flavor 
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The flavor's Type can't be empty!")]
    public string Type { get; set; }

    public List<TreatFlavor> JoinEntities { get; set; }
  }
}