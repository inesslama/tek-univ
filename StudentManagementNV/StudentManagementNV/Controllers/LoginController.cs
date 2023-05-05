using StudentManagementNV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace StudentManagementNV.Controllers
{
    public class LoginController : Controller
    {
        //private SchoolSysDBEntities db = new SchoolSysDBEntities();
       // string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString ;
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        public ActionResult Login()
        {

            return View();
            
        }
        //public void connectionString() {

        //    // con.ConnectionString = "metadata=res://*/Models.Model1.csdl|res://*/Models.Model1.ssdl|res://*/Models.Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-411F89C;initial catalog=SchoolSysDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;database=SchoolSysDBEntities";
        //    con.ConnectionString = "metadata=res://*/Models.Model1.csdl|res://*/Models.Model1.ssdl|res://*/Models.Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-411F89C;initial catalog=SchoolSysDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";


        //}
      
        [HttpPost]
        public ActionResult Login(LoginViewModel acc)
        {

            //using (AppDbContext db = new AppDbContext())
            //{
            //    var usr = db.loginViewModel.Single(u => u.StudentId == std.StudentId && u.email == std.email && u.password == std.password);

            //    // var usr = db.Student.Single(u => u.email == std.email && u.password == std.password);
            //    if (usr != null)
            //    {

            //        Session["StudentId"] = usr.StudentId.ToString();
            //        Session["email"] = usr.email.ToString();

            //        if (Session["StudentId"] != null)
            //        {
            //            return RedirectToAction("IndexStudent", "Students");
            //        }
            //        else
            //        {
            //            return RedirectToAction("Login");
            //        }

            //    }
            //    else
            //    {

            //        ModelState.AddModelError("", "The user name or password provided is incorrect.");
            //    }
            //    return View();
            string connectionString = "database=SchoolSysDBEntities;data source=DESKTOP-411F89C;initial catalog=SchoolSysDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Faire quelque chose avec la connexion ici

                com.Connection = con;
                com.CommandText = "SELECT * from Student where StudentID ='" + acc.StudentId + "'and email ='" + acc.email + "'and password='" + acc.password + "'";
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    con.Close();
                    // return View("IndexStudent");
                    return RedirectToAction("IndexStudent", "Students");
                }
                else
                {
                    if(acc.StudentId == 123 && acc.email == "admin@gmail.com" && acc.password == "admin")
                    {
                        con.Close();
                        return RedirectToAction("IndexAdmin", "Admin");
                    }
                    else {
                        con.Close();
                        return View();
                    }
                    
                    
                }
            }
            }






        //[HttpPost]
        //public ActionResult Login(LoginViewModel std)
        //{

        //    Student t = db.Student.Where(x => x.email == std.email && x.password == std.password).SingleOrDefault();
        //    if (t != null)
        //    {
        //        FormsAuthentication.SetAuthCookie(t.email, false);
        //        return RedirectToAction("IndexStudents", "Students");
        //    }
        //    else
        //    {

        //        ModelState.AddModelError("", "The user name or password provided is incorrect.");
        //    }
        //    return View();
        //}
        //    return View();
        //    //if (std.email == "admin@admin" && std.password == "admin")
        //    //{
        //    //    // return View("Index", "Admin");
        //    //    return RedirectToAction("Index", "AdminController");
        //    //}
        //    //return View();
        //}

        //public ActionResult Login(LoginViewModel std)
        //{
        //    using (AppDbContext db = new AppDbContext())
        //    {
        //        var usr = db.loginViewModel.Single( u => u.StudentId == std.StudentId &&u.email == std.email && u.password == std.password);

        //        // var usr = db.Student.Single(u => u.email == std.email && u.password == std.password);
        //        if (usr != null)
        //        {

        //            Session["StudentId"] = usr.StudentId.ToString();
        //            Session["email"] = usr.email.ToString();

        //            if (Session["StudentId"] != null)
        //            {
        //                return RedirectToAction("IndexStudent", "Students");
        //            }
        //            else
        //            {
        //                return RedirectToAction("Login");
        //            }

        //        }
        //        else
        //        {

        //            ModelState.AddModelError("", "The user name or password provided is incorrect.");
        //        }
        //        return View();

        //    }



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(LoginViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    // Vérifier les informations de connexion ici
        //    if (model.StudentId == 0 && model.email == "admin@gmail.com" && model.password == "admin")
        //    {
        //        // Si l'authentification réussit, enregistrer l'ID utilisateur dans une session et rediriger vers la page d'accueil
        //        Session["Id"] = 123;
        //        return RedirectToAction("IndexAdmin", "Admin");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "Les informations de connexion sont incorrectes.");
        //        return View(model);
        //    }
        //}
    }



    }


