using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPProject.Models
{
    public class User
    {
        [Display(Name = "User Id")]
        public int UserID { get; set; }

        [Display(Name = "Username")]
        [Required]
        public string Username { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Mobile")]
        [Required]
        [RegularExpression(@"^\d{10}$")]
        public string Mobile { get; set; }
    }
}