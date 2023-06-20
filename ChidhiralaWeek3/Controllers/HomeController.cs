using ChidhiralaWeek3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// Created By Chidhirala

namespace ChidhiralaWeek3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new RealEstateModel());
        }

        [HttpPost]
        public IActionResult Result(RealEstateModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateHomeValue();
                return View(model);
            }
            return View("Index", model);
        }//Result
    }//Class
}//NameSpace