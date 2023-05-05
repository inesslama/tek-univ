using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManagementNV.Models
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext() : base("SchoolSysDB")
        //{

        //}
        //public DbSet<Class> classes{ get; set; }
       
        //public DbSet<Student> Students { get;set; }
      //  public DbSet<Exam> exams { get;set; }
      //  public DbSet<Subject> subjects { get;set; } 
        public DbSet<LoginViewModel> loginViewModel { get;set; }    
    }
}