using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pierres.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "* The treat's Type can't be empty!")]
    public string Type { get; set; }

    public List<TreatFlavor> JoinEntities { get; set; }
  }
}