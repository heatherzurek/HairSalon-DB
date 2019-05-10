using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{

    public class Client
    {
        private string _name;
        private int _id;
        private int _stylistId;


      public Client (string name, int stylistId, int id = 0)
      // int stylistId , int id = 0
      {
          _name = name;
          _stylistId = stylistId;
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

      public int GetStylistId()
      {
          return _stylistId;
      }

      public static List<Client> GetAll()
    {
      List<Client> allClients = new List<Client> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM clients;";
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        string clientName = rdr.GetString(0);
        int clientId = rdr.GetInt32(1);
        int clientStylistId = rdr.GetInt32(2);
        Client newClient = new Client(clientName, clientStylistId, clientId);
        allClients.Add(newClient);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allClients;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO clients (client_name, stylist_id) VALUES (@clientName, @stylist_id);";
      MySqlParameter clientName = new MySqlParameter();
      clientName.ParameterName = "@clientName";
      clientName.Value = this._name;
      cmd.Parameters.Add(_name);
      MySqlParameter stylistId = new MySqlParameter();
      stylistId.ParameterName = "@stylist_id";
      stylistId.Value = this._stylistId;
      cmd.Parameters.Add(_stylistId);
      cmd.ExecuteNonQuery();
      _id = (int) cmd.LastInsertedId;
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }



      // public static List<Client> GetAll()
      // // this is where items from the database will go
      // {
      //     List<Client> allClients = new List<Client> { };
      //     MySqlConnection conn = DB.Connection();
      //     //calling that database connection
      //     conn.Open();
      //     //opens database
      //     MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      //     //new instance of special object to call commands on db objects
      //     cmd.CommandText = @"SELECT * FROM clients;";
      //     //sql commands
      //     MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      //     //creates a data reader object - responsible for reading data returned by our database
      //     while(rdr.Read())
      //     {
      //       string clientName = rdr.GetString(1);
      //       int clientId = rdr.GetInt32(0);
      //       //once we collect the data we can use it to instanciate a new client object and add them to our allClients List
      //       Client newClient = new Client(clientName);
      //       allClients.Add(newClient);
      //     }
      //     //to close the database
      //     conn.Close();
      //
      //     if (conn != null)
      //     {
      //       conn.Dispose();
      //     }
      //
      //     return allClients;
      //   }

        // public static Client Find(int searchId)
        // {
        //   // Temporarily returning dummy item to get beyond compiler errors, until we refactor to work with database.
        //   Client dummyClient = new Client("dummy client");
        //   return dummyClient;
        // }

        // public int GetId()
        // {
        //   // Temporarily returning dummy id to get beyond compiler errors, until we refactor to work with database.
        //   return _id;
        // }

        // public override bool Equals(System.Object otherClient)
        // {
        //   if (!(otherClient is Client))
        //   {
        //     return false;
        //   }
        //   else
        //   {
        //     Client newClient = (Client) otherClient;
        //     bool nameEquality = (this.GetClient() == newClient.GetClient());
        //     return (nameEquality);
        //   }
        // }

        public static void ClearAll()
        {
          MySqlConnection conn = DB.Connection();
          conn.Open();
          var cmd = conn.CreateCommand() as MySqlCommand;
          cmd.CommandText = @"DELETE FROM clients;";
          cmd.ExecuteNonQuery();
          conn.Close();
          if (conn != null)
          {
           conn.Dispose();
          }
        }

    }
}
