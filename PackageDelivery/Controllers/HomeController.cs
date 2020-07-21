using Microsoft.AspNetCore.Mvc;
using PackageDelivery.Models;
using System.Collections.Generic;

namespace PackageDelivery.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}