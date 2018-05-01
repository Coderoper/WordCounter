using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterApp.Models;
using System;

namespace WordCounterApp.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View("CreateForm");
      }

      [HttpGet("/wordcounter/new")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/wordcounter")]
      public ActionResult Create()
      {
        RepeatCounter newRepeatCounter =new RepeatCounter(Request.Form["new-word"], Request.Form["new-string"]);


        return View("Index");
      }



    }


}
