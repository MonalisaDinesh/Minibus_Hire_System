using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minibus_Hire_System.web.Models.SignIn
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address1 is Required")]
        [Display(Name = "Address1")]
        public string Address1 { get; set; }

        [Required(ErrorMessage = "Address2 is Required")]
        [Display(Name = "Address2")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Address3 is Required")]
        [Display(Name = "Address3")]
        public string Address3 { get; set; }

        [Required(ErrorMessage = "City is Required")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "County is Required")]
        [Display(Name = "County")]
        public string County { get; set; }

        [Required(ErrorMessage = "Country is Required")]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "PhoneNumber is Required")]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
