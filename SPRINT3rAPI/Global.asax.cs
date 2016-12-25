using System.Web;
using System.Web.Http;

namespace SPRINT3rAPI
{
	public class Global : HttpApplication
	{
		protected void Application_Start()
		{
			GlobalConfiguration.Configure(WebApiConfig.Register);
		}
	}
}
