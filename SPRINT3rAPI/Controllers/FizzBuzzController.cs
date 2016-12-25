using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPRINT3r;
using System.Web.Http.Cors;

namespace SPRINT3rAPI.Controllers
{
	[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
	public class FizzBuzzController : Controller
    {
		public ActionResult Count()
        {
			var fb = new FizzBuzz();
			int value = 0;
			Int32.TryParse(RouteData.Values["id"].ToString(), out value);

			var data = new { Input = value, Count = fb.Count(value) };

			this.ControllerContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
			return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
