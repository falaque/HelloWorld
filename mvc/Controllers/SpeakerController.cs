using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Conference.Models;

namespace Conference.Controllers
{
    public class SpeakerController : Controller
    {
        private ConferenceContext db = new ConferenceContext();

        //
        // GET: /Speaker/

        public ActionResult Index()
        {
            return View(db.Speakers.ToList());
        }

        //
        // GET: /Speaker/Details/5

        public ActionResult Details(int id = 0)
        {
            Speaker speaker = db.Speakers.Find(id);
            if (speaker == null)
            {
                return HttpNotFound();
            }
            return View(speaker);
        }

        //
        // GET: /Speaker/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Speaker/Create

        [HttpPost]
        public ActionResult Create(Speaker speaker)
        {
            if (ModelState.IsValid)
            {
                db.Speakers.Add(speaker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(speaker);
        }

        //
        // GET: /Speaker/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Speaker speaker = db.Speakers.Find(id);
            if (speaker == null)
            {
                return HttpNotFound();
            }
            return View(speaker);
        }

        //
        // POST: /Speaker/Edit/5

        [HttpPost]
        public ActionResult Edit(Speaker speaker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(speaker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(speaker);
        }

        //
        // GET: /Speaker/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Speaker speaker = db.Speakers.Find(id);
            if (speaker == null)
            {
                return HttpNotFound();
            }
            return View(speaker);
        }

        //
        // POST: /Speaker/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Speaker speaker = db.Speakers.Find(id);
            db.Speakers.Remove(speaker);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
