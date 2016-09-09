using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Day2.Controllers.Models;

namespace Day2.Controllers.Controllers
{
    public class CustomerController : BaseController
    {
        private UserCollection collection = UserCollection.GetInstance();

        [Route("~/Customer/Add-User")]
        [Route("~/User/Add-User")]
        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }

        [Route("~/Customer/Add-User")]
        [Route("~/User/Add-User")]
        [HttpPost]
        public async Task<JsonResult> AddUser(User newUser)
        {
            await Task.Factory.StartNew(() =>
            {
                collection.Add(newUser.Name, newUser.LastName);
            });
            return Json(collection.Users);
        }

        [Route("~/Customer/User-List")]
        [Route("~/User/User-List")]
        [HttpGet]
        public ActionResult List()
        {
            return View(collection.Users);
        }
    }
}