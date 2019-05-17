using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{

  public class Specialty
  {

    private string _type;
    private int _id;

    public Specialty(string type, int id = 0)
    {
      _type = type;
      _id = id;
    }

    public string GetType()
    {
        return _type;
    }

    public int GetId()
    {
        return _id;
    }

    public static void DeleteAll()
    {
        MySqlConnection conn = DB.Connection();
        conn.Open();
        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"DELETE FROM specialties;";
        cmd.ExecuteNonQuery();
        conn.Close();
        if (conn != null)
        {
            conn.Dispose();
        }
    }

    public override bool Equals(System.Object otherSpecialty)
    {
        if (!(otherSpecialty is Specialty))
        {
            return false;
        }
        else
        {
            Specialty newSpecialty = (Specialty) otherSpecialty;
            bool idEquality = this.GetId().Equals(newSpecialty.GetId());
            bool typeEquality = this.GetType().Equals(newSpecialty.GetType());
            return (idEquality && typeEquality);
        }
    }

    public static List<Specialty> GetAll()
    {
        List<Specialty> allSpecialtys = new List<Specialty> {};
        MySqlConnection conn = DB.Connection();
        conn.Open();
        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM specialties;";
        var rdr = cmd.ExecuteReader() as MySqlDataReader;
        while(rdr.Read())
        {
        string SpecialtyType = rdr.GetString(1);
        int SpecialtyId = rdr.GetInt32(0);
        Specialty newSpecialty = new Specialty(SpecialtyType, SpecialtyId);
        allSpecialtys.Add(newSpecialty);
        }
        conn.Close();
        if (conn != null)
        {
            conn.Dispose();
        }
        return allSpecialtys;
    }

    public void Save()
    {
        MySqlConnection conn = DB.Connection();
        conn.Open();
        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"INSERT INTO specialties (type, id) VALUES (@type, @id);";
        MySqlParameter type = new MySqlParameter();
        type.ParameterName = "@type";
        type.Value = this._type;
        cmd.Parameters.Add(type);
        MySqlParameter id = new MySqlParameter();
        id.ParameterName = "@id";
        id.Value = this._id;
        cmd.Parameters.Add(id);
        cmd.ExecuteNonQuery();
        _id = (int) cmd.LastInsertedId;
        conn.Close();
        if (conn != null)
        {
            conn.Dispose();
        }

    }

    public static Specialty Find(int id)
    {
        MySqlConnection conn = DB.Connection();
        conn.Open();
        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM specialties WHERE id = (@searchId);";
        MySqlParameter searchId = new MySqlParameter();
        searchId.ParameterName = "@searchId";
        searchId.Value = id;
        cmd.Parameters.Add(searchId);
        var rdr = cmd.ExecuteReader() as MySqlDataReader;
        int SpecialtyId = 0;
        string SpecialtyType = "";
        while(rdr.Read())
        {
          SpecialtyId = rdr.GetInt32(0);
          SpecialtyType = rdr.GetString(1);
        }
        Specialty newSpecialty = new Specialty(SpecialtyType, SpecialtyId);
        conn.Close();
        if (conn != null)
        {
            conn.Dispose();
        }
        return newSpecialty;
    }


    public void AddStylist(Stylist newStylist)
  {
    MySqlConnection conn = DB.Connection();
    conn.Open();
    var cmd = conn.CreateCommand() as MySqlCommand;
    cmd.CommandText = @"INSERT INTO specialties (specialty_id, stylist_id) VALUES (@SpecialtyId, @StylistId);";
    MySqlParameter specialty_id = new MySqlParameter();
    specialty_id.ParameterName = "@SpecialtyId";
    specialty_id.Value = Id;
    cmd.Parameters.Add(specialty_id);

    MySqlParameter stylist_id = new MySqlParameter();
    stylist_id.ParameterName = "@StylistId";
    stylist_id.Value = newStylist.Id;
    cmd.Parameters.Add(stylist_id);
    cmd.ExecuteNonQuery();
    conn.Close();
    if (conn != null)
    {
      conn.Dispose();
    }
  }

    }
  }
