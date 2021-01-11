using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ModelContext _db;

        public HomeController(ILogger<HomeController> logger, ModelContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.todotasks.ToList());
        }

        public IActionResult BuildToDoTable()
        {
            return PartialView("_ToDoTable", _db.todotasks.ToList());
        }

        public IActionResult Edit(int? todotaskid)
        {
            Todotask todotask = null;
            if(todotaskid != null)
            {
                todotask = _db.todotasks.Where(x => x.TodotaskID == todotaskid).FirstOrDefault();
                
            }

            return View(todotask);
        }
        [HttpPost]
        public IActionResult Edit(int? todotaskid, Todotask tasks)
        {
            Todotask todotask = _db.todotasks.Where(x => x.TodotaskID == todotaskid).FirstOrDefault();
            if(todotaskid != null)
            {
                todotask.TodotaskName = tasks.TodotaskName;
                todotask.isDone = tasks.isDone;
                if (ModelState.IsValid)
                {
                    _db.SaveChanges();
                    return RedirectToAction("index");
                }else
                {
                    ViewBag.Message = "Update Failed";
                    ViewBag.Status = "danger";
                }
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult delete()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
