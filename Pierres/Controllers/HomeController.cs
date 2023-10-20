using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;
using System.Linq;
// USING DIRECTIVES HERE

namespace Pierres.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresContext _db;

    public HomeController(PierresContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}