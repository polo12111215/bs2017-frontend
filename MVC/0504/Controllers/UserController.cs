using _0504.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0504.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(_0504.Models.Class1 pageData)
        {
            pageData.number = 1;
            pageData.choose = "收入";
            pageData.datatime = Convert.ToDateTime(DateTime.Now);
            pageData.coment = "123";
            return View(pageData);
        }
    }
}