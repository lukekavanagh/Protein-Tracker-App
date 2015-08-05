using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceStack.Redis;
using ProteinTracker.Models;

namespace ProteinTracker.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            using (IRedisClient client = new RedisClient())
            {
                var userClient = client.As<User>();
                var users = userClient.GetAll(); //get stuff in the database
                var usersSelection = new SelectList(users, "Id", "Name", String.Empty);
                ViewBag.Users = usersSelection;

            }

            return View();



        }
    }
}
