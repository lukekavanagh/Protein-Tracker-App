using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceStack.Redis;

namespace ProteinTracker.Controllers
{
    public class LeaderBoardController : Controller
    {
        //
        // GET: /LeaderBoard/

        public ActionResult Index()
        {

            using (IRedisClient client = new RedisClient())
            {
                var leaderboard = client.GetAllWithScoresFromSortedSet("urn:leaderboard");
                ViewBag.leaders = leaderboard;
            }
            return View();
        }

    }
}
