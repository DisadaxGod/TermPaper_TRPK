using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Views
{
    public class TrafficPoliceOfficerController : Controller
    {
        private ITEntities db = new ITEntities();

        // GET: TrafficPoliceOfficer
        public ActionResult Index()
        {
            return View(db.TrafficPoliceOfficer.ToList());
        }

        // GET: TrafficPoliceOfficer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrafficPoliceOfficer trafficPoliceOfficer = db.TrafficPoliceOfficer.Find(id);
            if (trafficPoliceOfficer == null)
            {
                return HttpNotFound();
            }
            return View(trafficPoliceOfficer);
        }

        // GET: TrafficPoliceOfficer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrafficPoliceOfficer/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTrafficPoliceOfficer,passportData,login,pasword,fullName,rank,position")] TrafficPoliceOfficer trafficPoliceOfficer)
        {
            if (ModelState.IsValid)
            {
                db.TrafficPoliceOfficer.Add(trafficPoliceOfficer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trafficPoliceOfficer);
        }

        // GET: TrafficPoliceOfficer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrafficPoliceOfficer trafficPoliceOfficer = db.TrafficPoliceOfficer.Find(id);
            if (trafficPoliceOfficer == null)
            {
                return HttpNotFound();
            }
            return View(trafficPoliceOfficer);
        }

        // POST: TrafficPoliceOfficer/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTrafficPoliceOfficer,passportData,login,pasword,fullName,rank,position")] TrafficPoliceOfficer trafficPoliceOfficer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trafficPoliceOfficer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trafficPoliceOfficer);
        }

        // GET: TrafficPoliceOfficer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrafficPoliceOfficer trafficPoliceOfficer = db.TrafficPoliceOfficer.Find(id);
            if (trafficPoliceOfficer == null)
            {
                return HttpNotFound();
            }
            return View(trafficPoliceOfficer);
        }

        // POST: TrafficPoliceOfficer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrafficPoliceOfficer trafficPoliceOfficer = db.TrafficPoliceOfficer.Find(id);
            db.TrafficPoliceOfficer.Remove(trafficPoliceOfficer);
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
