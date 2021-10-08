using Microsoft.AspNetCore.Mvc;

namespace Salon.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    { return View(); }
  }
}