using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Patients_Donors.Controllers
{
    public class PatientsController : Controller
    {
        Models.eBloodBanksEntities db = new Models.eBloodBanksEntities();
        //
        // GET: /Patients/

        public ActionResult Index()
        {
            return View(db.Patients);
        }

        public ActionResult Details(int id)
        {
            return View(db.Patients.Find(id));
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.Patients.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Models.Patient patient)
        {
            db.Entry(patient).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Patients");
        }

        public ActionResult Delet(int id)
        {
            return View(db.Patients.Find(id));
        }

        public ActionResult DeleteConfirm(int id)
        {
            Models.Patient formToDelet = db.Patients.Find(id);
            db.Patients.Remove(formToDelet);
            db.SaveChanges();
            return RedirectToAction("Index", "Patients");
        }

    }
}
