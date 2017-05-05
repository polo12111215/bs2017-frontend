using _0504.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;


namespace _0504.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            var pageData = new _0504.Models.Class1();
            var list  = new List<Class1>();
            Random a = new Random();

            CultureInfo enUS = new CultureInfo("en-US");
            DateTime dateValue;
            for (var i = 1; i <= 200; i++)
            {
                
               
                var b = a.Next(2);
                
                var d = a.Next(1000000);
               
                

                 DateTime.TryParseExact("20000505", "yyyyMMdd", enUS,
                             DateTimeStyles.None, out dateValue);
                
                
                pageData.number = i;
                if (b == 1)
                {
                    pageData.choose = "收入";
                }
                else
                {
                    pageData.choose = "支出";
                }
                
                list.Add(new Class1(){ number=i,choose=pageData.choose,datatime=dateValue.AddDays(d), money=d });
                
            }
                return View(list);
            
        }
    }
}