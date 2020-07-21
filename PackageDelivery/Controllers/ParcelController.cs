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

    // [HttpGet("/checkout")]
    // public ActionResult Checkout(int height, int width, int length, int weight)
    // {
    //   Parcel newParcel = new Parcel(height, width, length, weight);
    //   int parcelVolume = newParcel.findVolume();
    //   int parcelPrice = newParcel.findPrice(parcelVolume);
    //   Console.WriteLine(parcelPrice);
    //   // return View(parcelPrice);

    [HttpPost("/checkout")]
    public ActionResult Checkout(int height, int width, int length, int weight)
    {
      Parcel newParcel = new Parcel(height, width, length, weight);
      int parcelVolume = newParcel.findVolume();
      int parcelPrice = newParcel.findPrice(parcelVolume);
      return View(parcelPrice);
    }
  }
}


// public class HomeController : Controller
// {

//   [Route("/")]
//   public ActionResult Form() { return View(); }

//   [Route("/result")]
//   public ActionResult Result(string adj1, string food1, string vegetable1, string food2, string vegetable2, string verb1, string verb2, string vegetable3, string vegetable4, string verb3)
//   {
//     MadLibsVariable newMadLibs = new MadLibsVariable(adj1, food1, vegetable1, food2, vegetable2, verb1, verb2, vegetable3, vegetable4, verb3);
//     return View(newMadLibs);
//   }
// }