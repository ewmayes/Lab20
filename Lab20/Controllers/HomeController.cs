using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab20.Models;

namespace Lab20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Registration(string FirstName)
        {
            ViewBag.Message = "Hellosfsfd " + FirstName + "!";

            return View("AddUser");
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult AddNewCustomer(User newUser)
        {
            CoffeeShopDBEntities1 MyORM = new CoffeeShopDBEntities1();
            MyORM.Users.Add(newUser);
            MyORM.SaveChanges();
            ViewBag.Message = "Hello " + newUser.FirstName + "!";
            return View("AddUser");
        }

        public ActionResult ItemAdmin()
        {
            CoffeeShopDBEntities1 MyORM = new CoffeeShopDBEntities1();
            ViewBag.ItemData = MyORM.Items.ToList();
            return View();
        }

        //public ActionResult UpdateItemByName(string Name)
        //{
        //    CoffeeShopDBEntities1 MyORM = new CoffeeShopDBEntities1();
        //    Item ToBeUpdated = MyORM.Items.Find(Name);
        //    ViewBag.ItemToBeUpdated = ToBeUpdated;
        //    return View("ItemAdmin");
        //}


        //public ActionResult EditItem(string Item)
        //{
        //    CoffeeShopDBEntities1 MyORM = new CoffeeShopDBEntities1();
        //    Item ToBeUpdated = MyORM.Items.Find(Item);
        //    ViewBag.ToBeUpdated = ToBeUpdated;
        //    return View("ItemAdmin");
        //}
    }
}