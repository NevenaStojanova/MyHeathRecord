using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthRecords.Models
{
    public class AddUserToRole
    {
        public string Email { get; set; }
        public List<String> Roles { get; set; }
        [Display(Name = "Role")]
        public string selectedRole { get; set; }
    }
}