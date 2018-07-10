using Microsoft.AspNetCore.Mvc;
using AnimalShelterProject.Models;

namespace AnimalShelterProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}