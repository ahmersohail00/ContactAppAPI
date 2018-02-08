using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactAppAPI.Models
{
    public class Contact
    {
        public int ID { get; set; }
        [MaxLength(255)]
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string LastName { get; set; }
        [MaxLength(255)]
        public string Phone { get; set; }
        [MaxLength(255)]
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(255)]
        public string ImageURL { get; set; }
        public bool Blocked { get; set; }
    }
}