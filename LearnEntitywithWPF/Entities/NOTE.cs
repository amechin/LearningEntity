//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearnEntitywithWPF.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class NOTE
    {
        public int ID_NOTE { get; set; }
        public int ID_PRODUIT { get; set; }
        public int ID_COMMANDE { get; set; }
        public double NOTE1 { get; set; }
        public System.DateTime DATE_NOTE { get; set; }
        public string DESCRIPTION { get; set; }
        public bool ACTIF { get; set; }
    }
}