using System.Web.Mvc;
using Ext.Net;
using Ext.Net.MVC;
using Started.Models;

namespace Started.Controllers
{
    public class ExtNetController : Controller
    {
        public ActionResult Index()
        {
            ExtNetModel model = new ExtNetModel()
            {
                Title = "Добро пожаловать",
                TextAreaEmptyText = "Введите текст"
            };

            return this.View(model);
        }

        public ActionResult SampleAction(string message)
        {
            NotificationConfig config = new NotificationConfig();
            config.Icon = Icon.Accept;
            config.Title = "Working";
            config.Html = message;

            X.Msg.Notify(config).Show();

            return this.Direct();
        }

        public ActionResult Button()
        {
            return View();
        }
    }
}