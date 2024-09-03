using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Online_Training_management_system.Models
{
    //Model for trainings table
    public class Trainings
    {

        public int TrainingId { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public string TrainingName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public System.DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Range(0,int.MaxValue,ErrorMessage ="Please enter a valid integer number")]
        public decimal Fees { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}