using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class Cource_DetailsController : Controller
    {
        private StudentDataEntities db = new StudentDataEntities();

        // GET: cource_Details
        public ActionResult Index()
        {
            return View(db.cource_Details.ToList());
        }

        // GET: cource_Details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cource_Details cource_Details = db.cource_Details.Find(id);
            if (cource_Details == null)
            {
                return HttpNotFound();
            }
            return View(cource_Details);
        }

        // GET: cource_Details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cource_Details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,cource_Name,duration")] cource_Details cource_Details)
        {
            if (ModelState.IsValid)
            {
                db.cource_Details.Add(cource_Details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cource_Details);
        }

        // GET: cource_Details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cource_Details cource_Details = db.cource_Details.Find(id);
            if (cource_Details == null)
            {
                return HttpNotFound();
            }
            return View(cource_Details);
        }

        // POST: cource_Details/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,cource_Name,duration")] cource_Details cource_Details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cource_Details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cource_Details);
        }

        // GET: cource_Details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cource_Details cource_Details = db.cource_Details.Find(id);
            if (cource_Details == null)
            {
                return HttpNotFound();
            }
            return View(cource_Details);
        }

        // POST: cource_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cource_Details cource_Details = db.cource_Details.Find(id);
            db.cource_Details.Remove(cource_Details);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
