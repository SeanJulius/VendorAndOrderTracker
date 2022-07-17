using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
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
      Vendor newVendor = new Vendor("testName","testDescript");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      Vendor newVendor = new Vendor("testName","testDescript");
      string name = "testName";
      string result = newVendor.Name;
      Assert.AreEqual(result,name);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      Vendor newVendor = new Vendor("testName","testDescript");
      string description = "testDescript";
      string result = newVendor.Description;
      Assert.AreEqual(result,description);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      Vendor newVendor = new Vendor("testName","testDescript");
      string updatedName = "updatedName";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(result,updatedName);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      Vendor newVendor = new Vendor("testName","testDescript");
      string updatedDescript = "updatedDescript";
      newVendor.Description = updatedDescript;
      string result = newVendor.Description;
      Assert.AreEqual(result,updatedDescript);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      string name01 = "Pierre's";
      string description01 = "Sound Stage";
      string name02 = "Fred's";
      string description02 = "Hair Salon";
      Vendor newVendor1 = new Vendor(name01,description01);
      Vendor newVendor2 = new Vendor(name02,description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}