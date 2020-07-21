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
      int depth = 10;
      Parcel parcelTest = new Parcel(10, 15, 10, 10);
      int testHeight = parcelTest.Height;
      int testWidth = parcelTest.Width;
      int testDepth = parcelTest.Depth;
      Assert.AreEqual(height, testHeight);
      Assert.AreEqual(width, testWidth);
      Assert.AreEqual(depth, testDepth);
    }
    [TestMethod]
    public void GetWeight_ShouldHaveWeight_BeWeighty()
    {
      Parcel parcelTest = new Parcel(10, 15, 10, 20);
      Assert.AreEqual(parcelTest.Weight, 10);
    }
  }
}