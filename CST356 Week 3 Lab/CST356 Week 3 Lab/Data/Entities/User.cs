using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CST356_Week_3_Lab.Data.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [DisplayName("Years in School")]
        public int YearsInSchool { get; set; }
    }
}