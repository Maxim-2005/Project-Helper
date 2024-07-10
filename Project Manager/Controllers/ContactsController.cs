using Microsoft.AspNetCore.Mvc;

namespace Project_Manager.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
