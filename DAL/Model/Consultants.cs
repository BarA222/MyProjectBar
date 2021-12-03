using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Consultants
    {
        [Key]
        public int ConsultantsID { get; set; }

        [ForeignKey("Users")]
        public Guid UserId { get; set; }
        public Users Users { get; set; }

    }
}
