using Microsoft.AspNetCore.Mvc;
using PackageDelivery.Models;
using System.Collections.Generic;
using System;

namespace PackageDelivery.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/form")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/checkout")]
    public ActionResult Checkout(int height, int width, int length, int weight)
    {
      Parcel newParcel = new Parcel(height, width, length, weight);
      int parcelVolume = newParcel.findVolume();
      newParcel.findPrice(parcelVolume);
      return View(newParcel);
    }
  }
}