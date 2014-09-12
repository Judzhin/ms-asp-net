using System.Web.Mvc;
using Ext.Net;
using Ext.Net.MVC;
using Window.Models;

namespace Window.Controllers
{
    public class ExtNetController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult SampleAction(string message)
        {
            return this.Direct();
        }
    }
}