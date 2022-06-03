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
    public class DiagnosticMapController : Controller
    {
        private ITEntities db = new ITEntities();

        // GET: DiagnosticMap
        public ActionResult Index()
        {
            var diagnosticMap = db.DiagnosticMap.Include(d => d.Driver);
            return View(diagnosticMap.ToList());
        }

        // GET: DiagnosticMap/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiagnosticMap diagnosticMap = db.DiagnosticMap.Find(id);
            if (diagnosticMap == null)
            {
                return HttpNotFound();
            }
            return View(diagnosticMap);
        }

        // GET: DiagnosticMap/Create
        public ActionResult Create()
        {
            ViewBag.Driver_idDriver = new SelectList(db.Driver, "idDriver", "driverCertificateNumber");
            return View();
        }

        // POST: DiagnosticMap/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idDiagnosticMap,Driver_idDriver,stateCarNumber,engineNumber,color,carModel")] DiagnosticMap diagnosticMap)
        {
            if (ModelState.IsValid)
            {
                db.DiagnosticMap.Add(diagnosticMap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Driver_idDriver = new SelectList(db.Driver, "idDriver", "driverCertificateNumber", diagnosticMap.Driver_idDriver);
            return View(diagnosticMap);
        }

        // GET: DiagnosticMap/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiagnosticMap diagnosticMap = db.DiagnosticMap.Find(id);
            if (diagnosticMap == null)
            {
                return HttpNotFound();
            }
            ViewBag.Driver_idDriver = new SelectList(db.Driver, "idDriver", "driverCertificateNumber", diagnosticMap.Driver_idDriver);
            return View(diagnosticMap);
        }

        // POST: DiagnosticMap/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idDiagnosticMap,Driver_idDriver,stateCarNumber,engineNumber,color,carModel")] DiagnosticMap diagnosticMap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diagnosticMap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Driver_idDriver = new SelectList(db.Driver, "idDriver", "driverCertificateNumber", diagnosticMap.Driver_idDriver);
            return View(diagnosticMap);
        }

        // GET: DiagnosticMap/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiagnosticMap diagnosticMap = db.DiagnosticMap.Find(id);
            if (diagnosticMap == null)
            {
                return HttpNotFound();
            }
            return View(diagnosticMap);
        }

        // POST: DiagnosticMap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DiagnosticMap diagnosticMap = db.DiagnosticMap.Find(id);
            db.DiagnosticMap.Remove(diagnosticMap);
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
