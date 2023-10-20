using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Pierres.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser> userManager, PierresContext db)
    {
      _db = db;
      _userManager = userManager;
    }

    public ActionResult Index()
    {
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      Treat[] treats = _db.Treats.ToArray();
      Flavor[] flavors = _db.Flavors.ToArray();

      model.Add("treats", treats);
      model.Add("flavors", flavors);

      return View(model);
    }
  }
}