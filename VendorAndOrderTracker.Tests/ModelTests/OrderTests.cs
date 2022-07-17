using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
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
      Order newOrder = new Order("title","description",0,"date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      Order newOrder = new Order("title","description",0,"date");
      string title = "title";
      string result = newOrder.Title;
      Assert.AreEqual(result,title);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      Order newOrder = new Order("testTitle","testDescript",0,"testDate");
      string description = "testDescript";
      string result = newOrder.Description;
      Assert.AreEqual(result,description);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      Order newOrder = new Order("testTitle","testDescript",0,"testDate");
      string updatedTitle = "updatedTitle";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(result,updatedTitle);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      Order newOrder = new Order("testTitle","testDescript",0,"testDate");
      string updatedDescript = "updatedDescript";
      newOrder.Description = updatedDescript;
      string result = newOrder.Description;
      Assert.AreEqual(result,updatedDescript);
    }
  }
}