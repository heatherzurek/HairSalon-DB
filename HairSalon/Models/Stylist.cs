using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{

    public class Stylist
    {

        private string _name;
        private int _id;

        public Stylist(string name, int id = 0)
        {
            _name = name;
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetId()
        {
            return _id;
        }

        public static List<Stylist> GetAll()
        {
            List<Stylist> allStylists = new List<Stylist> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM stylists;";
            var rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
            int StylistId = rdr.GetInt32(1);
            string StylistName = rdr.GetString(0);
            Stylist newStylist = new Stylist(StylistName);
            allStylists.Add(newStylist);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allStylists;
        }
        //
        // public static Stylist Find(int id)
        // {
        //     MySqlConnection conn = DB.Connection();
        //     conn.Open();
        //     var cmd = conn.CreateCommand() as MySqlCommand;
        //     cmd.CommandText = @"SELECT * FROM categories WHERE id = (@searchId);";
        //     MySqlParameter searchId = new MySqlParameter();
        //     searchId.ParameterName = "@searchId";
        //     searchId.Value = id;
        //     cmd.Parameters.Add(searchId);
        //     var rdr = cmd.ExecuteReader() as MySqlDataReader;
        //     int StylistId = 0;
        //     string CategoryName = "";
        //     while(rdr.Read())
        //     {
        //       CategoryId = rdr.GetInt32(0);
        //       CategoryName = rdr.GetString(1);
        //     }
        //     Category newCategory = new Category(CategoryName, CategoryId);
        //     conn.Close();
        //     if (conn != null)
        //     {
        //         conn.Dispose();
        //     }
        //     return newCategory;
        // }
        //
        // public static void DeleteAll()
        // {
        //     MySqlConnection conn = DB.Connection();
        //     conn.Open();
        //     var cmd = conn.CreateCommand() as MySqlCommand;
        //     cmd.CommandText = @"DELETE FROM categories;";
        //     cmd.ExecuteNonQuery();
        //     conn.Close();
        //     if (conn != null)
        //     {
        //         conn.Dispose();
        //     }
        // }

    }

}
