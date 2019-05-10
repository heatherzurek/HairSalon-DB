using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest
  {
    //
    // public void Dispose()
    // {
    //   Stylist.ClearAll();
    // }

    [TestMethod]
    public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
    {
      Stylist newStylist = new Stylist("test stylist");
      Assert.AreEqual(typeof(Stylist), newStylist.GetType());
    }
    //
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Stylist";
      Stylist newStylist = new Stylist(name);

      //Act
      string result = newStylist.GetName();

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsStylistId_Int()
    {
      //Arrange
      string name = "Test Stylist";
      Stylist newStylist = new Stylist(name);

      //Act
      int result = newStylist.GetId();

      //Assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Save_SavesToDatabase_StylistList()
    {
      //Arrange
      Stylist testStylist = new Stylist("Dwight", 5);

      //Act
      testStylist.Save();
      List<Stylist> result = Stylist.GetAll();
      List<Stylist> testList = new List<Stylist>{testStylist};

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }
    // [TestMethod]
    // public void GetAll_ReturnsAllStylistObjects_StylistList()
    // {
    //   //Arrange
    //   string name01 = "Dwight";
    //   string name02 = "Angela";
    //   Stylist newStylist1 = new Stylist(name01);
    //   Stylist newStylist2 = new Stylist(name02);
    //   List<Stylist> newList = new List<Stylist> { newStylist1, newStylist2 };
    //
    //   //Act
    //   List<Stylist> result = Stylist.GetAll();
    //
    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void Find_ReturnsCorrectStylist_Category()
    // {
    //   //Arrange
    //   string name01 = "Work";
    //   string name02 = "School";
    //   Category newCategory1 = new Category(name01);
    //   Category newCategory2 = new Category(name02);
    //
    //   //Act
    //   Category result = Category.Find(2);
    //
    //   //Assert
    //   Assert.AreEqual(newCategory2, result);
    // }
    //
    // [TestMethod]
    // public void GetStylists_ReturnsEmptyStylistList_ItemList()
    // {
    //   //Arrange
    //   string name = "Work";
    //   Category newCategory = new Category(name);
    //   List<Item> newList = new List<Item> { };
    //
    //   //Act
    //   List<Item> result = newCategory.GetItems();
    //
    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
    //
    // [TestMethod]
    // public void AddItem_AssociatesItemWithCategory_ItemList()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);
    //   List<Item> newList = new List<Item> { newItem };
    //   string name = "Work";
    //   Category newCategory = new Category(name);
    //   newCategory.AddItem(newItem);
    //
    //   //Act
    //   List<Item> result = newCategory.GetItems();
    //
    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

  }
}
