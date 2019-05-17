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

    public string GetSpecialtyType()
    {
        return _type;
    }



  }
}
