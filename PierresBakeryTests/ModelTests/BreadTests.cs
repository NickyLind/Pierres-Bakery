using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // Test methods go here
    [TestMethod]
public void Bread_IsInstanceOfBread_True()
{
  Bread newBread = new Bread(5);
  Assert.AreEqual(typeof(Bread), newBread.GetType());
}
  }
}