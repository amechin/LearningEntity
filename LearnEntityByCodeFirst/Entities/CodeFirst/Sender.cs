using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEntityByCodeFirst.Entities.CodeFirst
{
    public class Sender
    {
        //decorateur ou annotation : a pour objectif de changer les propriétés
        [Key] public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //clé étrangère sur le Mail
        public virtual ICollection<MailServer> MailServers { get; set; }
    }
}
