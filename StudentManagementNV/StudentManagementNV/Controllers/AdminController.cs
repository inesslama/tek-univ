using StudentManagementNV.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementNV.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private SchoolSysDBEntities db = new SchoolSysDBEntities();
        public ActionResult IndexAdmin()
        {
            return View();
        }
        public ActionResult Classes()
        {
           // return View("~/Views/Classes/Index");
          //  return View(db.Class.ToList());
          return RedirectToAction("Index","Classes"); 
        }
        
    public ActionResult Teachers()
        {
            return RedirectToAction("Index", "Teachers");
           
        }
        public ActionResult Students()
        {
            return  RedirectToAction("Index","Students");
        }
        public ActionResult Subjects()
        {
            return RedirectToAction("Index", "Subjects");
        }
        public ActionResult Emails()
        {
            return View();
        }
    }
}