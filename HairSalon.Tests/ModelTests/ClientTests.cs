using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{

  [TestClass]
  public class ClientTest
  {

    public void Dispose()
    {
      Client.ClearAll();
    }

    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=heather_zurek_test;";
    }

      [TestMethod]
      public void ClientConstructor_CreatesInstanceOfClient_Client()
      {
        //arrange
        Client newClient = new Client("name");

        //assert
        Assert.AreEqual(typeof(Client), newClient.GetType());
      }

      [TestMethod]
      public void GetName_ReturnsName_String()
      {
        //Arrange
        string name = "alex";
        Client newClient = new Client(name);

        //Act
        string result = newClient.GetName();

        //Assert
        Assert.AreEqual(name, result);
      }

      [TestMethod]
      public void SetName_SetName_String()
      {
        //Arrange
        string name = "alex";
        Client newClient = new Client(name);

        //Act
        string updatedName = "bryan";
        newClient.SetName(updatedName);
        string result = newClient.GetName();

        //Assert
        Assert.AreEqual(updatedName, result);
      }

      [TestMethod]
      public void GetAll_ReturnsEmptyListFromDatabase_ClientList()
      {
        //Arrange
        List<Client> newList = new List<Client> { };

        //Act
        List<Client> result = Client.GetAll();

        //Assert
        CollectionAssert.AreEqual(newList, result);
      }

      [TestMethod]
      public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Client()
      {
        // Arrange, Act
        Client firstClient = new Client("bob");
        Client secondClient = new Client("bill");

        // Assert
        Assert.AreEqual(firstClient, secondClient);
      }
      // //
      // [TestMethod]
      // public void GetAll_ReturnsEmptyListFromDatabase_ClientList()
      // {
      //   //Arrange
      //   List<Client> newList = new List<Client> { };
      //
      //   //Act
      //   List<Client> result = Client.GetAll();
      //
      //   //Assert
      //   CollectionAssert.AreEqual(newList, result);
      // }

  }

}
