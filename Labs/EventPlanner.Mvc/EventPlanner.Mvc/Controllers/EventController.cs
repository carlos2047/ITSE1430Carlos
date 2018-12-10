using EventPlanner.Memory;
using EventPlanner.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventPlanner.Mvc.Controllers
{
	public class EventController : Controller
	{
		public EventController()
		{
			_database = new MemoryEventDatabase();
		}

		public ActionResult Index(EventCriteria criteria)
		{
			var items = _database.GetAll(criteria);

			return View(items.Select(i => new model(i)));
			//return View("Index");
		}

		[HttpGet]
		public ActionResult My()
		{
			var model = new model();

			return View(model);
		}

		[HttpPost]
		public ActionResult My(model model)
		{
			return View(model);
		}

		private readonly IEventDatabase _database;
	}		
}