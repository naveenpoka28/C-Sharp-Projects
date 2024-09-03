using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationsystemm.Models
{
    public class UserDetails
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        [StringLength(35,ErrorMessage ="Name should be less than 35 characters")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name ="Last Name")]
        [StringLength(35,ErrorMessage ="last name should be between 35 characters")]
        public string LastName { get; set; }
        [Required]
        [Display(Name ="Email Id")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50,ErrorMessage ="Email should be less than 50 characters")]
        public string EmailId { get; set; }
        [Required]
        [StringLength(15,ErrorMessage ="Password should be less than 15 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}