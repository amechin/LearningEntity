using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEntityByCodeFirst.Entities.CodeFirst
{
    public class MailServer
    {   
        [Column("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }
        public string Host { get; set; }
        public string Username { get; set; }
        public Password Password { get; set; }
        public string IpAdress { get; set; }
        //Relation ManytoMany
        public virtual ICollection<Sender> Senders { get; set; }
    }
}
