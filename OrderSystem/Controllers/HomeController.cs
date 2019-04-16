using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSystem.Models;

namespace OrderSystem.Controllers
{
    public class HomeController : Controller
    {
        OrderingSystemContext _context;

        public HomeController(OrderingSystemContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(IFormCollection keyValues)
        {
            var firstname = keyValues["firstname"][0];
            var lastname = keyValues["lastname"][0];
            var email_id = keyValues["email_id"][0];
            var password = keyValues["password"][0];
            var address = keyValues["address"][0];
            var city = keyValues["city"][0];
            var state = keyValues["state"][0];
            var zipcode = keyValues["zipcode"][0];
            var dob = keyValues["dob"][0];

            var isUSerAlreadyInDB = false;
            isUSerAlreadyInDB = _context.User_Registration.Where(x => x.Email_ID.ToLower() == email_id.ToLower()).Any();
            if (isUSerAlreadyInDB)
            {
                TempData["Error"] = "user already in the system";
                TempData.Keep("Error");
                return RedirectToAction("Index");
            }

            User_Registration user_Registration = new User_Registration();
            user_Registration.First_Name = firstname;
            user_Registration.Last_Name = lastname;
            user_Registration.Email_ID = email_id;
            user_Registration.User_Password = password;
            user_Registration.User_Address = address;
            user_Registration.City_Name = city;
            user_Registration.State_Name = state;
            user_Registration.Zip_Code = zipcode;
            user_Registration.Date_Of_Birth= dob;
            user_Registration.User_Status = true;

            _context.User_Registration.Add(user_Registration);
            _context.SaveChanges();


            return RedirectToAction("Login");
        }

        public IActionResult About()
        {
            if (TempData["Error"] != null)
            {
                ViewData["Error"] = TempData["Error"];
            }
            return View();
        }

        public IActionResult Contact_Us()
        {
            if (TempData["Error"] != null)
            {
                ViewData["Error"] = TempData["Error"];
            }
            return View();
        }

        [Authorize]
        public IActionResult My_Account()
        {
            if (TempData["Error"] != null)
            {
                ViewData["Error"] = TempData["Error"];
            }
            return View();
        }

        public IActionResult Terms()
        {
            if (TempData["Error"] != null)
            {
                ViewData["Error"] = TempData["Error"];
            }
            return View();
        }

        public IActionResult Signup()
        {
            if (TempData["Error"] != null)
            {
                ViewData["Error"] = TempData["Error"];
            }
            return View();
        }


        public IActionResult Login()
        {
            if (TempData["Error"] != null)
            {
                ViewData["Error"] = TempData["Error"];
            }
            return View();
        }

        public IActionResult LoginValidate(IFormCollection keyValues)
        {
            var email_id = keyValues["email_id"][0];
            var password = keyValues["password"][0];
            User_Registration user_Registration = new User_Registration();
            user_Registration.Email_ID = email_id;
            user_Registration.User_Password = password;

            var IsUserValidate = true;
            IsUserValidate = _context.User_Registration.Where(x => x.Email_ID.ToLower() == email_id.ToLower() && x.User_Password == password).Any();
            if (IsUserValidate == false)
            {
                TempData["Error"] = "User Name or Password is incorrect!! Please try again";
                TempData.Keep("Error");
                return RedirectToAction("Login");
            }
            return RedirectToAction("Privacy");
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
