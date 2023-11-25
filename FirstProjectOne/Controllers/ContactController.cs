using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProjectOne.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public ContentResult Greet()
        {
            return Content("Hello Everyone");
        }
        public int add()
        {
            int a = 5;
            int sa= 5;
            int fa= 5;
          

            int b = 6;
            int s = a + b;
            return s;
        }
    }
}