using Jockey.Data;
using Jockey.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jockey.Controllers
{

    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ApplicationTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get ApplicationType
        public IActionResult Index()
        {
            IEnumerable<ApplicationType> objList = _db.ApplicationType;
            return View(objList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //Post CREATE
        [HttpPost]
        [IgnoreAntiforgeryToken]
        public IActionResult Create(ApplicationType obj)
        {
            _db.ApplicationType.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
