using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LocalProject.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public void Index()
		{
			List<User> users = new List<User>();

			using (var context = new LocalProjectContext())
			{
				var user = context.Users.Where(x => x.Id == 1).FirstOrDefault();
				var itemToRemove = context.Addresses.Where(x => x.Id == 6).FirstOrDefault();
				user.Addresses.Remove(itemToRemove);
				context.SaveChanges();
			}


			//return View(users);
		}
	}
}