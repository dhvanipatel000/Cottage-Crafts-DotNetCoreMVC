using cottage_crafts.data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using cottage_crafts.Models;
using System;
using System.Collections.Generic;

namespace cottage_crafts.Controllers
{
    public class CraftsController : Controller
    {
        private readonly AppDbContext context;
       
        public CraftsController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var result = context.Crafts.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Crafts model)
        {
            if (ModelState.IsValid)
            {
                var c = new Crafts()
                {
                    cname = model.cname,
                    cprice = model.cprice,
                    cdesc = model.cdesc,
                    cimg = model.cimg,
                    ccategory = model.ccategory
                };
                context.Crafts.Add(c);
                context.SaveChanges();
                TempData["msg"] = "Item added";
                return RedirectToAction("Index");

            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            var c = context.Crafts.SingleOrDefault(c => c.cid == id);
            context.Crafts.Remove(c);
            context.SaveChanges();
            TempData["msg"] = "Item removed";
            return RedirectToAction("Index");
        }

        
        public IActionResult Edit(int id)
        {
            var c = context.Crafts.SingleOrDefault(c => c.cid == id);
            var result = new Crafts()
            {
                cname = c.cname,
                cprice = c.cprice,
                cdesc = c.cdesc,
                cimg = c.cimg,
                ccategory = c.ccategory
            };
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Crafts model)
        {
            var c = new Crafts()
            {
                cid = model.cid,
                cname = model.cname,
                cprice = model.cprice,
                cdesc = model.cdesc,
                cimg = model.cimg,
                ccategory = model.ccategory
            };
            context.Crafts.Update(c);
            context.SaveChanges();
            TempData["msg"] = "Item Updated";
            return RedirectToAction("Index");
        }
        
    }
}


