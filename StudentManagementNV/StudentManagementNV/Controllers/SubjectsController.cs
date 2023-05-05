using StudentManagementNV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementNV.Controllers
{
    public class SubjectsController : Controller
    {
        // GET: Subjects
        private SchoolSysDBEntities db = new SchoolSysDBEntities();
       
        public ActionResult Index()
        {
            return View(db.Subject.ToList());
        }

        // GET: Subjects/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Subjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subjects/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Subjects/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Subjects/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Subjects/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Subjects/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
