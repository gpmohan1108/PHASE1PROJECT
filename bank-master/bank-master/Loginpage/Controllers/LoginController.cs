using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loginpage.Models;

namespace Loginpage.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public List<UserModel> PutValue()
        {
            var users = new List<UserModel>
            {
                new UserModel{id=1,userid=12345,password="Mohann"},
                new UserModel{id=2,userid=13579,password="Mohan123"},
                new UserModel{id=3,userid=24680,password="Mohan2001"},
                new UserModel{id=4,userid=12300,password="Mohanabc"}
            };

            return users;
        }

        [HttpPost]
        public IActionResult Verify(UserModel usr)
        {
            var u = PutValue();

            var ue = u.Where(u => u.userid.Equals(usr.userid));

            var up = ue.Where(p => p.password.Equals(usr.password));

            if(up.Count()==1)
            {
                ViewBag.message = "Login Success";
                return View("LoginSuccess");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Login");
            }
        }
    }
}
