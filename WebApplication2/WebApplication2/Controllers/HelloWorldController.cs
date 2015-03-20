using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        public string Welcome(string name = "Georgia", int id = 1)
        {
            return HttpUtility.HtmlEncode("Hallo " + name + ", the number is:" + id);
        }
        
    }
}