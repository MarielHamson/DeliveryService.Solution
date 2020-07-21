using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackageDelivery.Models;

namespace PackageDelivery.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelMeasure_DoesParcelHaveDimensions_ItShould()
    {
    Parcel parcelTest = new Parcel();
    Assert.AreEqual(typeof(Parcel), parcelTest.GetType());
    }
  }
}