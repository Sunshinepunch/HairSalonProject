using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;


namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly SalonContext _db;
    
    public ClientsController(SalonContext db) {
      _db = db;
    }

    public ActionResult Index() {
      List<Client> model = _db.Client_Info.Include(client => client.Stylist).ToList();
      return View(model);
    }

    public ActionResult Create() {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client Client) {
      _db.Client_Info.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details (int id) {
      Client thisClient = _db.Client_Info.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    public ActionResult Edit (int id) {
      var thisClient = _db.Client_Info.FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList (_db.Stylists, "StylistId", "StylistName");
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit (Client Client) {
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id) {
      var thisClient = _db.Client_Info.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id) {
      var thisClient = _db.Client_Info.FirstOrDefault(client => client.ClientId == id);
      _db.Client_Info.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


//     public ActionResult Search() 
//     {
      
//       return View();
//     }

//     [HttpPost]
//     public ActionResult Search(string ClientName) 
//     {
//       string searchName = ClientName.ToLower();
//       List<Client> searchResults = _db.Client_Info.Where(client => client.ClientName.ToLower().Contains(searchName)).ToList();
//       return View("Index", searchResults);
//     }
//   }

// }
