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
    
    public partial class UTILISATEUR
    {
        public int ID_UTILISATEUR { get; set; }
        public int ID_GENRE { get; set; }
        public int ID_PROFIL { get; set; }
        public Nullable<int> ID_SOCIETE { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        public string MOT_DE_PASSE { get; set; }
        public string EMAIL { get; set; }
        public System.DateTime DATE_DE_NAISSANCE { get; set; }
        public string TEL { get; set; }
    }
}
