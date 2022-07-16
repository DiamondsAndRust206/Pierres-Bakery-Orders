using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderOrganizer.Models;
using System;

namespace OrderOrganizer.Tests
{
  [TestClass]
  public class VendorTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   Vendor.ClearAll();
    // }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Vendor", "Best treats in town!");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

  }
}