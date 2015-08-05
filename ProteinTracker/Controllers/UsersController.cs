using System.Web.Mvc;

namespace ProteinTracker.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult NewUser()
        {
            return View();
        }
    }
}