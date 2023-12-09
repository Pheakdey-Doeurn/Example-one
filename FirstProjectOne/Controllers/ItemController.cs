using FirstProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProjectOne.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.shopName = "Computer Shop";
            List<Itemlist> itemList = new List<Itemlist>()
            {
                new Itemlist() {id=001,name="Acer",price=500,category="Computer"},
                new Itemlist() {id=002,name="Dell",price=300,category="Computer"},
                new Itemlist() {id=003,name="HP",price=400,category="Computer"},
                new Itemlist() {id=004,name="Asuz",price=350,category="Laptop"},
            };
            itemList.Add(new Itemlist { id = 005, name = "MSI", price = 450, category = "Laptop" });
            return View(itemList);
        }
    }
}