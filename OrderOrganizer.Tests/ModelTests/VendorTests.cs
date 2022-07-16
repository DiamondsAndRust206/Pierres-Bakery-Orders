using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderOrganizer.Models;
using System;

namespace OrderOrganizer.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

  }

}