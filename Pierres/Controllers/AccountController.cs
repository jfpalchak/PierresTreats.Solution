using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Pierres.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pierres.Controllers
{
  public class AccountController : Controller
  {
    private readonly PierresContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, PierresContext db)
    {
      _db = db;
      _userManager = userManager;
      _signInManager = signInManager;
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}