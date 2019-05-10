using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{

    public class StylistController : Controller
    {

        [HttpGet("/stylists")]
        public ActionResult Index()
        {
            List<Stylist> allStylists = Stylist.GetAll();
            return View(allStylists);
        }

        [HttpGet("/stylists/new")]
        public ActionResult New()
        {
          return View();
        }

        [HttpPost("/stylists")]
        public ActionResult Create(string stylistName)
        {
            Stylist newStylist = new Stylist(stylistName);
            newStylist.Save();
            List<Stylist> allStylists = Stylist.GetAll();
            return View("Index", allStylists);
        }

        [HttpGet("/stylists/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist selectedStylist = Stylist.Find(id);
            List<Client> stylistClients = selectedStylist.GetClients();
            model.Add("stylist", selectedStylist);
            model.Add("clients", stylistClients);
            return View(model);
        }
        //
        // [HttpPost("/categories/{stylistId}/items")]
        // public ActionResult Create(int categoryId, string itemDescription, DateTime itemDueDate)
        // {
        //     Dictionary<string, object> model = new Dictionary<string, object>();
        //     Stylist foundStylist = Category.Find(categoryId);
        //     Client newItem = new Item(itemDescription, itemDueDate, categoryId);
        //     newItem.Save();
        //     List<Item> categoryItems = foundCategory.GetItems();
        //     model.Add("items", categoryItems);
        //     model.Add("category", foundCategory);
        //     return View("Show", model);
        // }

    }

}
