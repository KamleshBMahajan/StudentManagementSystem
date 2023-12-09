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
    public class Batch_DetailsController : Controller
    {
        private StudentDataEntities db = new StudentDataEntities();

        // GET: Batch_Details
        public ActionResult Index()
        {
            return View(db.batch_Details.ToList());
        }

        // GET: Batch_Details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            batch_Details batch_Details = db.batch_Details.Find(id);
            if (batch_Details == null)
            {
                return HttpNotFound();
            }
            return View(batch_Details);
        }

        // GET: Batch_Details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Batch_Details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,batch,year")] batch_Details batch_Details)
        {
            if (ModelState.IsValid)
            {
                db.batch_Details.Add(batch_Details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(batch_Details);
        }

        // GET: Batch_Details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            batch_Details batch_Details = db.batch_Details.Find(id);
            if (batch_Details == null)
            {
                return HttpNotFound();
            }
            return View(batch_Details);
        }

        // POST: Batch_Details/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,batch,year")] batch_Details batch_Details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(batch_Details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(batch_Details);
        }

        // GET: Batch_Details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            batch_Details batch_Details = db.batch_Details.Find(id);
            if (batch_Details == null)
            {
                return HttpNotFound();
            }
            return View(batch_Details);
        }

        // POST: Batch_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            batch_Details batch_Details = db.batch_Details.Find(id);
            db.batch_Details.Remove(batch_Details);
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
