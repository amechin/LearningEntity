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
    
    public partial class FACTURE
    {
        public int ID_FACTURE { get; set; }
        public int ID_COMMANDE { get; set; }
        public int ID_ADRESSE { get; set; }
        public decimal TOTAL_FACTURE { get; set; }
        public bool FACTUREE { get; set; }
    }
}
