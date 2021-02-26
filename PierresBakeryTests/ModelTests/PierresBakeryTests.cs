using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_IsInstanceOfBread_True()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void Bread_CanReadAmount_True()
    {
      Bread newBread = new Bread(5);
      int result = newBread.AmountOfBread;
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void Bread_CorrectPricing_True()
    {
      Bread newBread = new Bread(5);
      int result = newBread.BreadDeal();

      Assert.AreEqual(20, result);
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_IsInstanceOfPastry_True()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void Pastry_CanReadAmount_True()
    {
      Pastry newPastry = new Pastry(5);
      int result = newPastry.AmountOfPastries;
      Assert.AreEqual(5, result);
    }

    // [TestMethod]
    // public void Pastry_CorrectPricing_True()
    // {
    //   Pastry newPastry = new Pastry(5);
    //   int result = newPastry.PastryDeal();

    //   Assert.AreEqual(20, result);
    // }
  }
}