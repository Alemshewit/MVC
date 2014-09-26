using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Patients_Donors.Controllers
{
    public class DonorsController : Controller
    {
        //
        // GET: /Donors/

        Models.eBloodBanksEntities db = new Models.eBloodBanksEntities();
        //
        // GET: /Patients/

        public ActionResult Index()
        {
            return View(db.Donors);
        }

        public ActionResult Details(int id)
        {
            return View(db.Donors.Find(id));
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.Donors.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Models.Donor donor)
        {
            db.Entry(donor).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Donors");
        }

        public ActionResult Delet(int id)
        {
            return View(db.Donors.Find(id));
        }

        public ActionResult DeleteConfirm(int id)
        {
            Models.Donor formToDelet = db.Donors.Find(id);
            db.Donors.Remove(formToDelet);
            db.SaveChanges();
            return RedirectToAction("Index", "Donors");
        }

    }
}
