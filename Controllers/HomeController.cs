using Microsoft.AspNetCore.Mvc;
using vuejscore.Models;

namespace vuejscore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new FlowOneBlock() {
                Title="Hello world",
                StepOne = new StepOneBlock
                {
                    Name = "1",
                },
                StepTwo = new StepTwoBlock
                {
                    Name = "2"
                }
            });
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
