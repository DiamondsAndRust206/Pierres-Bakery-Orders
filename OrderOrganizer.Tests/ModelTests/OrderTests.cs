using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderOrganizer.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
    Order.ClearAll();
    }

  }

}