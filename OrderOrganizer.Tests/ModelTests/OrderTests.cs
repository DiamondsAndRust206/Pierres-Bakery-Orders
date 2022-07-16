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
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order ("Antonio", "Restaurant", 42, 2065551234, "07/16/2022");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnsTotalPRICE_Int()
    {
      int PastryPrice = 3;
      int total = 42 ;
      Order newOrder = new ("Antonio", "Restaurant", total, 2065551234, "07/16/2022");
      int result = newOrder.TotalPrice;
      total *= PastryPrice;
      Assert.AreEqual(total, result);
    }
    [TestMethod]
    public void SetTitle_ReturnsSetTitle_String()
    {
      string title = "Restaurant";
      Order newOrder = new Order ("Antonio", title, 42, 2065551234, "01/16/2022");
      string updatedTitle = "Pizzeria";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsItems_OrderList()
    {
      string name01 = "Antonio";
      string name02 = "Sally";
      Order newOrder1 = new Order (name01, "Restaurant", 42,2065551234, "07/16/2022");
      Order newOrder2 = new Order(name02, "Bakery", 60, 2065554321, "05/05/2022");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetPropertiesOfObject_ReturnsPropertiesOfObject_StringAndIntegers()
    {
      string name = "Antonio";
      string title = "Restaurant";
      int phonenumber =2065551234;
      int price = 42;
      int PastryPrice = 3;
      price *= PastryPrice;
      string date = "07/16/2022";
      Order newOrder = new Order(name, title, 42, phonenumber, date);
      Order nextOrder = new Order(name, "Restaurant", 42, 2065551234, "07/17/2022");
      
      string nameResult = newOrder.Name;
      string titleResult = newOrder.Title;
      int priceResult = newOrder.TotalPrice;
      int phonenumberResult = newOrder.PhoneNumber;
      string dateResult = newOrder.Date;
      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(phonenumber, phonenumberResult);
      Assert.AreEqual(price, priceResult);
      Assert.AreEqual(date, dateResult);
    }

  }
}