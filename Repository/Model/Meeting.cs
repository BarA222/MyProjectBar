using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class Meeting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MeetingId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(50)]
        public string MeetingSubject { get; set; }
        [Required]
        public string Description { get; set; }

        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Customer Customer { get; set; }

        public void UpdateDescription(string description)
        {
            this.Description = description;
        }

        public void UpdateSubject(string subject)
        {
            this.MeetingSubject = subject;
        }

        public void UpdateDate(DateTime date)
        {
            this.Date = date;
        }

        public void UpdateUser(User user)
        {
            this.User = user;
        }

    }
}
