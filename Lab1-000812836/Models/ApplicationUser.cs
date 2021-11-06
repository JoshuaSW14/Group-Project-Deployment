using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Lab1_TeamMembershipSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Date), Display(Name = "Birth Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? BirthDate { get; set; }

    }
}
