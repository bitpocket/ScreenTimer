using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScreenTimerWeb.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "ScreenTime manager.";
			ViewBag.Version = "Version 0.0.1 (initial)";

			return View();
		}
	}
}