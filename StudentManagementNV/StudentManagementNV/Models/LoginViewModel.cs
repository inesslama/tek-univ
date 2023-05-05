using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace StudentManagementNV.Models
{
    public class LoginViewModel
    {
        
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

    }
}