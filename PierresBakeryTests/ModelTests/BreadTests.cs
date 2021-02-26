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
  }
}