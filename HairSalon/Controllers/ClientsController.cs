using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
{

  [HttpGet("/clients")]
  public ActionResult Index()
  {
      List<Client> allClients = Client.GetAll();
      return View(allClients);
  }

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

    [HttpPost("/clients/{clientId}/delete")]
    public ActionResult DeleteClient(int clientId)
    {
      Client Client = Client.Find(clientId);
      Client.DeleteClient();
      List<Client> allClients = Client.GetAll();
      return RedirectToAction("Index", allClients);
    }
  }
}
