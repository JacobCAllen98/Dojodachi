using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojodachi.Models;

namespace dojodachi.Controllers
{
    public class HomeController : Controller
    {
        public static Kirby kirby = new Kirby();

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(kirby);
        }
        
        [HttpGet("Feed")]
        public IActionResult Feed()
        {
            kirby.Feed();
            return RedirectToAction("Index");
        }
        [HttpGet("Play")]
        public IActionResult Play()
        {
            kirby.Play();
            return RedirectToAction("Index");
        }
        [HttpGet("Work")]
        public IActionResult Work()
        {
            kirby.Work();
            return RedirectToAction("Index");
        }
        [HttpGet("Sleep")]
        public IActionResult Sleep()
        {
            kirby.Sleep();
            return RedirectToAction("Index");
        }
        [HttpGet("Reset")]
        public IActionResult Reset()
        {
            kirby = new Kirby();
            return RedirectToAction("Index");
        }
    }
}
