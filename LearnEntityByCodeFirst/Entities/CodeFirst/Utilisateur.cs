using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEntityByCodeFirst.Entities.CodeFirst
{
    public class Utilisateur
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
        public string Gender { get; set; }
        [Key]
        public string Email { get; set; }
        public virtual ICollection<Address> Address { get; set; }

    }
}
