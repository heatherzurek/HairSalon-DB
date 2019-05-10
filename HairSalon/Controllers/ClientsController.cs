using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    [HttpGet("/stylists/{stylistId}/clients/new")]
    public ActionResult New(int stylistId)
    {
        Stylist stylist = Stylist.Find(stylistId);
        return View(stylist);
    }
    //
    [HttpGet("/stylists/{stylistId}/clients/{clientId}")]
    public ActionResult Show(int stylistId, int clientId)
    {
        Client client = Client.Find(clientId);
        Dictionary<string, object> model = new Dictionary<string, object>();
        Stylist stylist = Stylist.Find(stylistId);
        model.Add("client", client);
        model.Add("stylist", stylist);
        return View(model);
    }
    //
    // [HttpPost("/stylists/{stylistId}/clients/{clientId}/delete")]
    // public ActionResult DeleteClient(int stylistId, int clientId)
    // {
    //     Client item = Client.Find(itemId);
    //     item.Delete();
    //     Dictionary<string, object> model = new Dictionary<string, object>();
    //     Stylist foundStylist = Stylist.Find(stylistId);
    //     List<Client> stylistClients = foundStylist.GetItems();
    //     model.Add("clients", stylistItems);
    //     model.Add("stylist", foundStylist);
    //     return View(model);
    // }
    //
    // [HttpGet("/stylists/{stylistId}/clients/{itemId}/edit")]
    // public ActionResult Edit(int stylistId, int itemId)
    // {
    //     Dictionary<string, object> model = new Dictionary<string, object>();
    //     Stylist stylist = Stylist.Find(stylistId);
    //     model.Add("stylist", stylist);
    //     Item item = Item.Find(itemId);
    //     model.Add("item", item);
    //     return View(model);
    // }
    //
    // [HttpPost("/stylists/{stylistId}/clients/{itemId}")]
    // public ActionResult Update(int stylistId, int itemId, string newDescription)
    // {
    //     Item item = Item.Find(itemId);
    //     item.Edit(newDescription);
    //     Dictionary<string, object> model = new Dictionary<string, object>();
    //     Stylist stylist = Stylist.Find(stylistId);
    //     model.Add("stylist", stylist);
    //     model.Add("item", item);
    //     return View("Show", model);
    // }

  }
}
