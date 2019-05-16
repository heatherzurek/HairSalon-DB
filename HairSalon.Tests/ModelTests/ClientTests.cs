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

      // [TestMethod]
      // public void Equals_ReturnsTrueIfNamesAreTheSame_Client()
      // {
      //   // Arrange, Act
      //   Client firstClient = new Client("Dwight", 1);
      //   Client secondClient = new Client("Dwight", 1);
      //
      //   // Assert
      //   Assert.AreEqual(firstClient, secondClient);
      // }

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

      // [TestMethod]
      // public void GetAll_ReturnsClients_ClientList()
      // {
      //   //Arrange
      //   string clientName01 = "Dwight";
      //   string clientName02 = "Angela";
      //   Client newClient1 = new Client(clientName01, 1);
      //   // newClient1.Save();
      //   Client newClient2 = new Client(clientName02, 1);
      //   // newClient2.Save();
      //   List<Client> newList = new List<Client> { newClient1, newClient2 };
      //
      //   //Act
      //   List<Client> result = Client.GetAll();
      //
      //   //Assert
      //   CollectionAssert.AreEqual(newList, result);
      // }

      // [TestMethod]
      // public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Client()
      // {
      //   // Arrange, Act
      //   Client firstClient = new Client("bob");
      //   Client secondClient = new Client("bill");
      //
      //   // Assert
      //   Assert.AreEqual(firstClient, secondClient);
      // }
      // //

  }

}
