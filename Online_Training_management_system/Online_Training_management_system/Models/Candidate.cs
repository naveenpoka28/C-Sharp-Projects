using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Online_Training_management_system.Models
{
    //Model for candidate details
    public class Candidate
    {
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(20,ErrorMessage ="Please Enter mail which is less than 20 characters")]
        public string EmailAddress { get; set; }
        [Required]
        [MinLength(6,ErrorMessage ="Enter atleast six characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}