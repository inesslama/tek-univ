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
    
    public partial class Fees
    {
        public int FessId { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> FeesAmount { get; set; }
    
        public virtual Class Class { get; set; }
    }
}