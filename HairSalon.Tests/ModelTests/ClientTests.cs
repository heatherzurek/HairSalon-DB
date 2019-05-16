using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{

  [TestClass]
  public class ClientTest : IDisposable
  {

    public void Dispose()
    {
      Client.ClearAll();
      Stylist.DeleteAll();
    }

    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=heather_zurek_test;";
    }

      [TestMethod]
      public void ClientConstructor_CreatesInstanceOfClient_Client()
      {
        //arrange
        Client newClient = new Client("name", 1);

        //assert
        Assert.AreEqual(typeof(Client), newClient.GetType());
      }

      [TestMethod]
      public void GetName_ReturnsName_String()
      {
        //Arrange
        string name = "alex";
        Client newClient = new Client(name, 1);

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
        Client newClient = new Client(name, 1);

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
    public void GetAll_ReturnsClients_ClientList()
    {
      //Arrange
      Client newClient1 = new Client("Reese", 1);
      newClient1.Save();
      Client newClient2 = new Client("Katlin", 1);
      newClient2.Save();
      List<Client> newList = new List<Client> { newClient1, newClient2 };

      //Act
      List<Client> result = Client.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectClientFromDatabase_Client()
    {
      //Arrange
      Client testClient = new Client("Heather", 1);
      testClient.Save();

      //Act
      Client foundClient = Client.Find(testClient.GetId());

      //Assert
      Assert.AreEqual(testClient, foundClient);
    }

    [TestMethod]
    public void Equals_ReturnsTrueIfNamesAreTheSame_Client()
    {
      // Arrange, Act
      Client firstClient = new Client("Name", 1);
      Client secondClient = new Client("Name", 1);

      // Assert
      Assert.AreEqual(firstClient, secondClient);
    }

    [TestMethod]
    public void Save_SavesToDatabase_ClientList()
    {
      //Arrange
      Client testClient = new Client("Dwight", 1);

      //Act
      testClient.Save();
      List<Client> result = Client.GetAll();
      List<Client> testList = new List<Client>{testClient};

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void Save_AssignsIdToObject_Id()
    {
      //Arrange
      Client testClient = new Client("Dwight", 1);
      testClient.Save();

      //Act
      Client savedClient = Client.GetAll()[0];

      int result = savedClient.GetId();
      int testId = testClient.GetId();

      //Assert
      Assert.AreEqual(testId, result);
    }



  }

}
