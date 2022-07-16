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

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Vendor", "Best treats in town!");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorName_ReturnsName_String()
    {
      string vendor = "Giovannis Restaurante";
      Vendor newVendor = new Vendor(vendor, "Fine italian cuisine");
      string result = newVendor.VendorName;
      Assert.AreEqual(vendor, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendor = "Giovannis Restaurante";
      Vendor newVendor = new Vendor(vendor, "Fine italian cuisine");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendor01 = "Giovannis Restaurante";
      string vendor02 = "Victrola Coffee Roasters";
      string vendor03 = "Local Shop House";
      Vendor newVendor01 = new Vendor(vendor01, "Fine italian cuisine");
      Vendor newVendor02 = new Vendor(vendor02, "Coffee shop");
      Vendor newVendor03 = new Vendor(vendor03, "Sells local goods");
      List<Vendor>newList = new List<Vendor> { newVendor01, newVendor02 ,newVendor03};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor01 = "Giovannis Restaurante";
      string vendor02 = "Victrola Coffee Roasters";
      string vendor03 = "Local Shop House";
      Vendor newVendor01 = new Vendor(vendor01, "Fine italian cuisine");
      Vendor newVendor02 = new Vendor(vendor02, "Coffee shop");
      Vendor newVendor03 = new Vendor(vendor03, "Sells local goods");
      List<Vendor>newList = new List<Vendor> { newVendor01, newVendor02 ,newVendor03};
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor02, result);
    }
    [TestMethod]
    public void Getdescription_ReturnsDescripton_String()
    {
      string vendor01 = "Giovannis Restaurante";
      string description = "Fine italian cuisine";
      Vendor newVendor = new Vendor(vendor01, description);
      Vendor nextVendor = new Vendor("Victrola Coffee Roasters", "Coffee shop");
      string nameResult = newVendor.VendorName;
      string descriptionResult = newVendor.Description;
      Assert.AreEqual(vendor01, nameResult);
      Assert.AreEqual(description, descriptionResult);
    }

  }
}