using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class OpeningsController : Controller
  {

    [HttpGet("/openings")]
    public ActionResult Index()
    {
      List<JobOpening> allJobOpenings = JobOpening.GetAll();
      return View(allJobOpenings);
    }

    [HttpGet("/openings/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/openings")]
    public ActionResult Create(string title, string description, string contact)
    {
      JobOpening myJobOpening = new JobOpening(title, description, contact);
      return RedirectToAction("Index");
    }


    [HttpPost("/openings/delete")]
    public ActionResult DeleteAll()
    {
      JobOpening.ClearAll();
      return View();
    }

    [HttpGet("/openings/{id}")]
   public ActionResult Show(int id)
   {
     JobOpening jobOpening = JobOpening.Find(id);
     return View(jobOpening);
   }


  }
}
