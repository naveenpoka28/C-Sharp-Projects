using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Online_Training_management_system.Models
{
    //Model for registration details
    public class Registrations
    {

        public int RegistrationId { get; set; }
        [Required]
        public int TrainingId { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please Enter only numeric values")]
        public Nullable<decimal> FeesPaid { get; set; }
        public string Status { get; set; }

        public virtual Trainings Trainings { get; set; }
        public object TrainingName { get; internal set; }
        public object Fees { get; internal set; }
    }
}