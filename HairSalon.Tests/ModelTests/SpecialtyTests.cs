using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{

  [TestClass]
  public class SpecialtyTest : IDisposable
  {

    public void Dispose()
    {

      Specialty.DeleteAll();
    }

    public SpecialtyTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=heather_zurek_test;";
    }

    // [TestMethod]
    // public void SpecialtyConstructor_CreatesInstanceOfSpecialty_Specialty()
    // {
    //   Specialty newSpecialty = new Specialty("George Orwell", 1);
    //   Assert.AreEqual(typeof(Specialty), newSpecialty.GetType());
    // }

    [TestMethod]
    public void GetType_ReturnsType_String()
    {
      //Arrange
      string type = "Test Specialty";
      Specialty newSpecialty = new Specialty(type);
      //Act
      string result = newSpecialty.GetType();
      //assert
      Assert.AreEqual(type, result);
    }

    [TestMethod]
    public void GetId_ReturnsSpecialtyId_Int()
    {
      //Arrange
      string type = "Test Specialty";
      Specialty newSpecialty = new Specialty(type);

      //Act
      int result = newSpecialty.GetId();

      //Assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Save_SavesToDatabase_SpecialtyList()
    {
      //Arrange
      Specialty testSpecialty = new Specialty("Dwight", 5);

      //Act
      testSpecialty.Save();
      List<Specialty> result = Specialty.GetAll();
      List<Specialty> testList = new List<Specialty>{testSpecialty};

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void Find_ReturnsSpecialtyInDatabase_Specialty()
    {
      //Arrange
      Specialty testSpecialty = new Specialty("Color");
      testSpecialty.Save();

      //Act
      Specialty foundSpecialty = Specialty.Find(testSpecialty.GetId());

      //Assert
      Assert.AreEqual(testSpecialty, foundSpecialty);
    }


  }

}
