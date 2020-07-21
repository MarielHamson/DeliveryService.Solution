using Microsoft.AspNetCore.Mvc;
using PackageDelivery.Models;
using System.Collections.Generic;

namespace PackageDelivery.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/form")]
    public ActionResult Index()
    {
      return View();
    }
  }
}