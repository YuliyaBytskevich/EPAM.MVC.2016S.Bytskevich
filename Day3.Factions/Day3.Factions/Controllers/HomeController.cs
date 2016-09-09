using System.Diagnostics;
using System.Web.Mvc;
using Day3.Factions.Models;

namespace Day3.Factions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var crew = Crew.GetInstance();
            return View(crew.people);
        }

        [Route("~/Home/Index/id")]
        [Route("~/Home/Person/id")]
        public ActionResult DisplayPerson(int id)
        {
            var crew = Crew.GetInstance();
            return View("Person", crew.people.Find(x => x.Id == id));
        }

        [ChildActionOnly]
        public ActionResult Header(string side)
        {
            return PartialView("Header", side);
        }

        [ChildActionOnly]
        public ActionResult ChangeSide(Person person)
        {
            return PartialView("ChangeSide", person);
        }

        [HttpGet]
        public ActionResult DeclineToChangeFraction()
        {
            
            return PartialView("StayYourSideBox");
        }

        public ActionResult AcceptToChangeFaction(int id)
        {
            var crew = Crew.GetInstance();
            var person = crew.people.Find(x => x.Id == id);
            person.Side = Side.Dark;
            return RedirectToAction("DisplayPerson", new {id = person.Id});
        }
    }
}