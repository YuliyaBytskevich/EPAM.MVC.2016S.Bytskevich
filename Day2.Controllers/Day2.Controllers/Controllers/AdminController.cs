using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2.Controllers.Infrastructure;
using Day2.Controllers.Models;

namespace Day2.Controllers.Controllers
{ 
    public class AdminController : BaseController
    {
        private UserCollection collection = UserCollection.GetInstance();

        [Local]
        [Route("~/Admin")]
        [Route("~/Admin/Manage")]
        public ActionResult ManageUsers()
        {
            return View(collection.Users);
        }

        [Local]
        [HttpGet]
        public ActionResult EditUser(int id)
        {
            return View(collection.Users.Find(x => x.Id == id));
        }

        [Local]
        [HttpPost]
        public ActionResult EditUser(int id, string name, string lastName)
        {
            collection.Edit(id, name, lastName);
            return Json(collection.Users);
        }

        [Local]
        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            return View(collection.Users.Find(x => x.Id == id));
        }

        [Local]
        [HttpPost]
        public ActionResult DeleteUser(int id, string name)
        {
            collection.Delete(id);
            return Json(collection.Users);
        }
    }
}