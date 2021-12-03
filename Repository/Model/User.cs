using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        public UserType UserType { get; set; }

        public virtual List<Meeting> Meetings { get; set; }

        public void UpdatePassword(string password)
        {
            this.Password = password;
        }
    }

    public enum UserType
    {
        Admin = 2,
        Consultant = 1
    }
}
