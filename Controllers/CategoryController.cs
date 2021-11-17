using Jockey.Data;
using Jockey.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jockey.Controllers
{

    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
         
        //Get Category
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;
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
        public IActionResult Create(Category obj)
        {
            _db.Category.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}
