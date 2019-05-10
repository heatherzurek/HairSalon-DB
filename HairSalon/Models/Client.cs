using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{

    public class Client
    {
        private string _name;
        private int _id;
        // private int _stylistId;


      public Client (string name, int id = 0)
      // int stylistId
      {
          _name = name;
          // _stylistId = stylistId;
          _id = id;
      }

      public string GetName()
      {
          return _name;
      }

      public void SetName(string newName)
      {
          _name = newName;
      }

      public int GetId()
      {
          return _id;
      }
      //
      // public int GetCategoryId()
      // {
      //     return _categoryId;
      // }

      public static List<Client> GetAll()
      // this is where items from the database will go
      {
          List<Client> allClients = new List<Client> {};
          MySqlConnection conn = DB.Connection();
          //calling that database connection
          conn.Open();
          //opens database
          MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
          //new instance of special object to call commands on db objects
          cmd.CommandText = @"SELECT * FROM clients;";
          //sql commands
          MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
          //creates a data reader object - responsible for reading data returned by our database
          while(rdr.Read())
          {
            string clientName = rdr.GetString(1);
            int clientId = rdr.GetInt32(0);
            //once we collect the data we can use it to instanciate a new client object and add them to our allClients List
            Client newClient = new Client(clientName, clientId);
            allClients.Add(newClient);
          }
          //to close the database
          conn.Close();

          if (conn != null)
          {
            conn.Dispose();
          }
          return allClients;
        }

    }
}
