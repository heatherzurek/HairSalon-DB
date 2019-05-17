using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{

    public class SpecialtyController : Controller
    {

        [HttpGet("/specialties")]
        public ActionResult Index()
        {
            List<Specialty> allSpecialtys = Specialty.GetAll();
            return View(allSpecialtys);
        }

        [HttpGet("/specialties/new")]
        public ActionResult New()
        {
          return View();
        }

        [HttpPost("/specialties")]
        public ActionResult Create(string specialtyType)
        {
            Specialty newSpecialty = new Specialty(specialtyType);
            newSpecialty.Save();
            List<Specialty> allSpecialtys = Specialty.GetAll();
            return View("Index", allSpecialtys);
        }
    }
}
