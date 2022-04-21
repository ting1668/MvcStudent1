using Microsoft.AspNetCore.Mvc;

namespace MvcStudent.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            @ViewData["Message"] = "今天天气不错！";
            return View();
        }

        public string Welcome(string name, int numTimes = 1)
        {
            return String.Format("name is {0},numTimes is {1}",name,numTimes);
        }
    }
}
