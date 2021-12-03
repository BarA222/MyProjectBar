using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Meetings
    {
        [Key]
        public int MeetingId { get; set; }

        [ForeignKey("Consultants")]
        public int ConsultantsID { get; set; }
        public Consultants Consultants { get; set; }

        [Required]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(50)]
        public string MeetingSubject { get; set; }
        public string Description { get; set; }


    }
}
