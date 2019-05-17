using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{

  [TestClass]
  public class SpecialtyTest
  {

    // public SpecialtyTest()
    // {
    //   DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=heather_zurek_test;";
    // }

    [TestMethod]
    public void SpecialtyConstructor_CreatesInstanceOfSpecialty_Specialty()
    {
      Specialty newSpecialty = new Specialty("test specialty");
      Assert.AreEqual(typeof(Specialty), newSpecialty.GetType());
    }

    [TestMethod]
    public void GetType_ReturnsType_String()
    {
      //Arrange
      string specialtyType = "Test Specialty";
      Specialty newSpecialty = new Specialty(specialtyType);
      //Act
      string result = newSpecialty.GetSpecialtyType();
      //assert
      Assert.AreEqual(specialtyType, result);
    }

    [TestMethod]
    public void GetId_ReturnsSpecialtyId_Int()
    {
      //Arrange
      string specialtyType = "Test Specialty";
      Specialty newSpecialty = new Specialty(specialtyType);

      //Act
      int result = newSpecialty.GetId();

      //Assert
      Assert.AreEqual(0, result);
    }

  }

}
