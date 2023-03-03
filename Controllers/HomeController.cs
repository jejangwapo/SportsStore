using Microsoft.AspNetCore.Mvc;

namespace Jejan_SportsStore.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index() => View();

    }
}
