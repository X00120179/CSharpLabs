using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// This class uses annotations to specify required fields, validation formats, and display names (for forms)
using System.ComponentModel.DataAnnotations;

namespace HelloWorldPart2.Models
{
    public class User
    {
        // This field is a required value
        [Required]
        // In a form the label 'first name' will be used for this field
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        // Default
        public User()
        {

        }
    }
}