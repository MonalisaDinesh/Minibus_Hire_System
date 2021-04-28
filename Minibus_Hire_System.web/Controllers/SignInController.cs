using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Minibus_Hire_System.Interfaces;
using Minibus_Hire_System.web.Models.SignIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minibus_Hire_System.web.Controllers
{
    public class SignInController : Controller
    {
        private readonly IUserService userService;

        public SignInController(IUserService _userService)
        {
            userService = _userService;
        }
        public IActionResult Index()
        {            
            return View();
        }

        //public IActionResult Registration()
        //{
        //    return View();
        //}

        [HttpPost]
        public bool Signin(SignInViewModel model)// string email, string password)
        {
            if (string.IsNullOrWhiteSpace(model.Email) || string.IsNullOrWhiteSpace(model.Password))
                return false;

            ///TODO::need to check the credential in database

            return true;
        }

        [HttpPost]
        public IActionResult Registration(RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction(nameof(Index));
                //return View(model);

            var result = userService.AddUser(new Object.UserObject
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address1 = model.Address1,
                Address2 = model.Address2,
                Address3 = model.Address3,
                City = model.City,
                County = model.County,
                Country = model.Country,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
            });

            if (result)
                return View();
            else
                return View(model);
        }
        
        public IList<string> ValidateRegistration(RegistrationViewModel model)
        {
            IList<string> validation = new List<string>();
            if (string.IsNullOrWhiteSpace(model.FirstName))
                validation.Add("First Name is required");
            if (string.IsNullOrWhiteSpace(model.LastName))
                validation.Add("Last Name is required");

            return validation;
        }
    }
}
