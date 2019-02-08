using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthRecords.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Surname")]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [RegularExpression("(^((((0[1-9])|([1-2][0-9])|(3[0-1]))|([1-9]))-(((0[1-9])|(1[0-2]))|([1-9]))-(([0-9]{2})|(((19)|([2]([0]{1})))([0-9]{2}))))$)", ErrorMessage = "Date format is not valid!")]
        public string Date { get; set; }
        [Required]
        public string Condition { get; set; }
        public Patient patient { get; set; }
        public Doctor doctor { get; set; }



    }
}