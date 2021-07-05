using ASPProject.DatabaseContext;
using ASPProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPProject.Controllers
{
    public class UserController : Controller
    {
        AspMvcContext context;

        public UserController()
        {
            context = new AspMvcContext();
        }

        // GET: User
        public ActionResult Index()
        { 
            return View(context.users.ToList());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                context.users.Add(user);
                context.SaveChanges();
                return Redirect("index");
            }
        }


        public ActionResult Delete(int UserId)
        {
            User user=context.users.Find(UserId);
            context.users.Remove(user);
            context.SaveChanges();
            return Redirect("index");
        }

        public ActionResult Search(User user)
        {
            return View("index",context.users.Where(u => u.Username.Contains(user.Username)).AsEnumerable());
        }
    }
}