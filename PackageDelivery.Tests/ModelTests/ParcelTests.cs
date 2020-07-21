using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackageDelivery.Models;

namespace PackageDelivery.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelConstructor_DoesParcelExist_Parcel()
    {
      Parcel parcelTest = new Parcel(9, 10, 11, 10);
      Assert.AreEqual(typeof(Parcel), parcelTest.GetType());
    }

    [TestMethod]
    public void GetDimensions_ReturnDimensions_Int()
    {
      int height = 10;
      int width = 15;
      int length = 10;
      Parcel parcelTest = new Parcel(10, 15, 10, 10);
      int testHeight = parcelTest.Height;
      int testWidth = parcelTest.Width;
      int testLength = parcelTest.Length;
      Assert.AreEqual(height, testHeight);
      Assert.AreEqual(width, testWidth);
      Assert.AreEqual(length, testLength);
    }
    [TestMethod]
    public void GetWeight_ShouldHaveWeight_BeWeighty()
    {
      Parcel parcelTest = new Parcel(10, 15, 10, 20);
      Assert.AreEqual(parcelTest.Weight, 20);
    }

    [TestMethod]
    public void FindVolume_CalcVolume_True()
    {
      Parcel parcelTest = new Parcel(10, 15, 10, 20);
      Assert.AreEqual(parcelTest.findVolume(), 1501);
    }
  }
}