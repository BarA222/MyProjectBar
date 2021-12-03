using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address{ get; set; }

        public virtual List<Meeting> Meetings { get; set; }

       
    }
}
