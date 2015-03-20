using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentgurusController : Controller
    {
        private StudentGuru2DBcontext db = new StudentGuru2DBcontext();

        // GET: Studentgurus
        public ActionResult Index()
        {
            return View(db.Studentguru.ToList());
        }

        // GET: Studentgurus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studentguru studentguru = db.Studentguru.Find(id);
            if (studentguru == null)
            {
                return HttpNotFound();
            }
            return View(studentguru);
        }

        // GET: Studentgurus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Studentgurus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")] Studentguru studentguru)
        {
            if (ModelState.IsValid)
            {
                db.Studentguru.Add(studentguru);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentguru);
        }

        // GET: Studentgurus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studentguru studentguru = db.Studentguru.Find(id);
            if (studentguru == null)
            {
                return HttpNotFound();
            }
            return View(studentguru);
        }

        // POST: Studentgurus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")] Studentguru studentguru)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentguru).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentguru);
        }

        // GET: Studentgurus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studentguru studentguru = db.Studentguru.Find(id);
            if (studentguru == null)
            {
                return HttpNotFound();
            }
            return View(studentguru);
        }

        // POST: Studentgurus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Studentguru studentguru = db.Studentguru.Find(id);
            db.Studentguru.Remove(studentguru);
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
