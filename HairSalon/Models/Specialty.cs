using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{

  public class Specialty
  {

    private string _specialtyType;
    private int _id;

    public Specialty(string specialtyType, int id = 0)
    {
      _specialtyType = specialtyType;
      _id = id;
    }

    public string GetSpecialtyType()
    {
        return _specialtyType;
    }

    public int GetId()
    {
        return _id;
    }





  }
}
