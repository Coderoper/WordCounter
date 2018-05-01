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
        return View();
      }

      [HttpPost("/submit")]
      public ActionResult Submit()
      {
        RepeatCounter newRepeatCounter =new RepeatCounter(Request.Form["new-word"], Request.Form["new-sentence"]);

        return View("Result", newRepeatCounter);
      }
      [HttpGet("/result")]
      public ActionResult Result()
      {
        return View("Result");
      }


    }


}
