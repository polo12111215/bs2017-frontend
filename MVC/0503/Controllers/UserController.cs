using _0503.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0503.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel pageData)
        {
            if (pageData.Account == "skill" &&
            pageData.Password == "tree")
            {
                pageData.Message =
                $"您使用{pageData.Account}登入成功。";
               ViewData["set"] = "alert alert-success";
            }
            else
            {
                pageData.Message =
                $"登入失敗。";
                ViewData["set"] = "alert alert-danger";
            }
            return View(pageData);
        }

     }
}