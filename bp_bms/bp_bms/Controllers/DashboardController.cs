using System.Web.Mvc;

namespace bp_bms.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/

        //This Controller will only invoke for authorized users
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
	}
}