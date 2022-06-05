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
    public class CharacteristicTIController : Controller
    {
        private ITEntities db = new ITEntities();

        // GET: CharacteristicTI
        public ActionResult Index()
        {
            return View(db.CharacteristicsTI.ToList());
        }

        // GET: CharacteristicTI/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharacteristicsTI characteristicsTI = db.CharacteristicsTI.Find(id);
            if (characteristicsTI == null)
            {
                return HttpNotFound();
            }
            return View(characteristicsTI);
        }

        // GET: CharacteristicTI/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CharacteristicTI/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCharacteristicsTI,brakeSystems,steering,lightDevices,windscreenWipers,tiresAndWheels,engine,structuralElements,safetyRequirements")] CharacteristicsTI characteristicsTI)
        {
            if (ModelState.IsValid)
            {
                db.CharacteristicsTI.Add(characteristicsTI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(characteristicsTI);
        }

        // GET: CharacteristicTI/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharacteristicsTI characteristicsTI = db.CharacteristicsTI.Find(id);
            if (characteristicsTI == null)
            {
                return HttpNotFound();
            }
            return View(characteristicsTI);
        }

        // POST: CharacteristicTI/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCharacteristicsTI,brakeSystems,steering,lightDevices,windscreenWipers,tiresAndWheels,engine,structuralElements,safetyRequirements")] CharacteristicsTI characteristicsTI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(characteristicsTI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(characteristicsTI);
        }

        // GET: CharacteristicTI/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharacteristicsTI characteristicsTI = db.CharacteristicsTI.Find(id);
            if (characteristicsTI == null)
            {
                return HttpNotFound();
            }
            return View(characteristicsTI);
        }

        // POST: CharacteristicTI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CharacteristicsTI characteristicsTI = db.CharacteristicsTI.Find(id);
            db.CharacteristicsTI.Remove(characteristicsTI);
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
