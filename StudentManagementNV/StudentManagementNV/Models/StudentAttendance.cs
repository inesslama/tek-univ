//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagementNV.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentAttendance
    {
        public int Id { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> SubjectId { get; set; }
        public string RollNo { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
