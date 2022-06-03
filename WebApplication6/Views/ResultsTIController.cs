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
    public class ResultsTIController : Controller
    {
        private ITEntities db = new ITEntities();

        // GET: ResultsTI
        public ActionResult Index()
        {
            var resultsTI = db.ResultsTI.Include(r => r.CharacteristicsTI).Include(r => r.TrafficPoliceOfficer);
            return View(resultsTI.ToList());
        }

        // GET: ResultsTI/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResultsTI resultsTI = db.ResultsTI.Find(id);
            if (resultsTI == null)
            {
                return HttpNotFound();
            }
            return View(resultsTI);
        }

        // GET: ResultsTI/Create
        public ActionResult Create()
        {
            ViewBag.CharacteristicsTI_idCharacteristicsTI = new SelectList(db.CharacteristicsTI, "idCharacteristicsTI", "idCharacteristicsTI");
            ViewBag.TrafficPoliceOfficer_idTrafficPoliceOfficer = new SelectList(db.TrafficPoliceOfficer, "idTrafficPoliceOfficer", "passportData");
            return View();
        }

        // POST: ResultsTI/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idResultsTI,TrafficPoliceOfficer_idTrafficPoliceOfficer,DiagnosticMap_idDiagnosticMap,CharacteristicsTI_idCharacteristicsTI,dateOfPassage,cityOfMaintenance,placeOfMaintenance,resultOfMaintenance")] ResultsTI resultsTI)
        {
            if (ModelState.IsValid)
            {
                db.ResultsTI.Add(resultsTI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CharacteristicsTI_idCharacteristicsTI = new SelectList(db.CharacteristicsTI, "idCharacteristicsTI", "idCharacteristicsTI", resultsTI.CharacteristicsTI_idCharacteristicsTI);
            ViewBag.TrafficPoliceOfficer_idTrafficPoliceOfficer = new SelectList(db.TrafficPoliceOfficer, "idTrafficPoliceOfficer", "passportData", resultsTI.TrafficPoliceOfficer_idTrafficPoliceOfficer);
            return View(resultsTI);
        }

        // GET: ResultsTI/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResultsTI resultsTI = db.ResultsTI.Find(id);
            if (resultsTI == null)
            {
                return HttpNotFound();
            }
            ViewBag.CharacteristicsTI_idCharacteristicsTI = new SelectList(db.CharacteristicsTI, "idCharacteristicsTI", "idCharacteristicsTI", resultsTI.CharacteristicsTI_idCharacteristicsTI);
            ViewBag.TrafficPoliceOfficer_idTrafficPoliceOfficer = new SelectList(db.TrafficPoliceOfficer, "idTrafficPoliceOfficer", "passportData", resultsTI.TrafficPoliceOfficer_idTrafficPoliceOfficer);
            return View(resultsTI);
        }

        // POST: ResultsTI/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idResultsTI,TrafficPoliceOfficer_idTrafficPoliceOfficer,DiagnosticMap_idDiagnosticMap,CharacteristicsTI_idCharacteristicsTI,dateOfPassage,cityOfMaintenance,placeOfMaintenance,resultOfMaintenance")] ResultsTI resultsTI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resultsTI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CharacteristicsTI_idCharacteristicsTI = new SelectList(db.CharacteristicsTI, "idCharacteristicsTI", "idCharacteristicsTI", resultsTI.CharacteristicsTI_idCharacteristicsTI);
            ViewBag.TrafficPoliceOfficer_idTrafficPoliceOfficer = new SelectList(db.TrafficPoliceOfficer, "idTrafficPoliceOfficer", "passportData", resultsTI.TrafficPoliceOfficer_idTrafficPoliceOfficer);
            return View(resultsTI);
        }

        // GET: ResultsTI/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResultsTI resultsTI = db.ResultsTI.Find(id);
            if (resultsTI == null)
            {
                return HttpNotFound();
            }
            return View(resultsTI);
        }

        // POST: ResultsTI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ResultsTI resultsTI = db.ResultsTI.Find(id);
            db.ResultsTI.Remove(resultsTI);
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
