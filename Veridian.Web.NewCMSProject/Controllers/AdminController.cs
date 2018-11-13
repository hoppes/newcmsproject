using System.Threading.Tasks;
using System.Web.Mvc;

namespace Veridian.Web.NewCMSProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sidebar Right Layout
        public ActionResult SidebarRight()
        {
            return View();
        }

        // GET: Sidebar Left Layout
        public ActionResult SidebarLeft()
        {
            return View();
        }

        // GET: Icons
        public ActionResult Icons()
        {
            return View();
        }

        // GET: Forms
        public ActionResult Forms()
        {
            return View();
        }

    }
}