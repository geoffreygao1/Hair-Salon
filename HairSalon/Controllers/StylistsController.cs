using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   List<Stylist> model = _db.Stylists.ToList();
    //   return View(model);
    // }

    public ActionResult Index(string name)
    {
      ViewBag.searchParameter = name;
      if (name == null)
      {
        List<Stylist> model = _db.Stylists.ToList();
        return View(model);
      }

      else
      {
        var stylists = from m in _db.Stylists
                       select m;
        stylists = stylists.Where(s => s.Name!.Contains(name));
        return View(stylists.ToList());
      }



    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists
                                  .Include(stylist => stylist.Clients)
                                  .FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    public ActionResult Edit(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Stylists.Update(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      _db.Stylists.Remove(thisStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // public ActionResult Search(string name)
    // {
    //   Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.Name == name);
    //   return RedirectToAction("Details", new { id = thisStylist.StylistId });
    // }
  }
}