using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public string Browse(string genre)
        {
            string msg = HttpUtility.HtmlEncode("Store.Browse , Genre = " + genre);
            return msg;
        }

        public string Details(int id)
        {
            return "Store.Details, ID = " + id;
        }
    }
}