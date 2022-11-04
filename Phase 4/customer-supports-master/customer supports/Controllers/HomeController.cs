
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using customer_supports.Models;
namespace customer_supports.Controllers
{
    public class HomeController : Controller
    {
        phase4Entities1 db = new phase4Entities1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(userinfo log)
        {
            var user = db.userinfoes.Where(x => x.userid == log.userid && x.passwords == log.passwords).Count();
            if (user > 0)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Dashboard()
        {
            custinfo c=new custinfo();
            return View(c);
        }
        [HttpPost]
        public ActionResult Dashboard(custinfo cust)
        {
            custinfo cs = new custinfo();
            cs.logid = cust.logid;
            cs.customer_email = cust.customer_email;    
            cs.customer_name = cust.customer_name;
            cs.log_status=cust.log_status;
            cs.descriptions = cust.descriptions;
            db.custinfoes.Add(cs);
            db.SaveChanges();
            Response.Write("<script> alert('complaint registered successfully')</script>");
            return View();

        }
    }
}