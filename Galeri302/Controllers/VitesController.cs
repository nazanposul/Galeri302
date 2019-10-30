using Galeri302.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Galeri302.Controllers
{
    public class VitesController : Controller
    {
        private G302Context db = new G302Context();
        // GET: Vites
        public ActionResult Index()
        {
            return View(db.yVites.ToList());
        }
        
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(yVites vitesler)
        {
            if (ModelState.IsValid)
            {
                
                db.yVites.Add(vitesler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           

            return View(vitesler);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yVites vitesler = db.yVites.Find(id);

            if (vitesler == null)
            {
                return HttpNotFound();
            }
           
            return View(vitesler);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(yVites vitesler)
        {
            if (ModelState.IsValid)
            {
               
                db.Entry(vitesler).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
           
            return View(vitesler);
        }
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yVites vitesler = await db.yVites.FindAsync(id);
            if (vitesler == null)
            {
                return HttpNotFound();
            }
            return View(vitesler);
        }
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yVites vitesler = await db.yVites.FindAsync(id);
            if (vitesler == null)
            {
                return HttpNotFound();
            }
            return View(vitesler);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            yVites vitesler = await db.yVites.FindAsync(id);
            db.yVites.Remove(vitesler);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }

}