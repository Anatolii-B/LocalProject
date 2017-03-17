using Model.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LocalProject.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			List<User> users = new List<User>();

			using (var context = new LocalProjectContext())
			{
				users = context.Users.ToList();
			}

			return View(users);
		}
	}
}