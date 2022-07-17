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

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string Title01 = "Pierre's";
      string description01 = "Sound Stage";
      string Title02 = "Fred's";
      string description02 = "Hair Salon";
      Order newOrder1 = new Order(Title01,description01,0,"testDate");
      Order newOrder2 = new Order(Title02,description02,0,"testDate");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string Title01 = "Sam";
      string description01 = "Sportsman";
      string Title02 = "Joe";
      string descripton02 = "Tractor";
      Order newOrder1 = new Order(Title01,description01,0,"testDate");
      Order newOrder2 = new Order(Title02,descripton02,0,"testDate");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2,result);
    }
  }
}