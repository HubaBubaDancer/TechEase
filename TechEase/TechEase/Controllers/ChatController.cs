using Microsoft.AspNetCore.Mvc;

namespace TechEase.Controllers;

public class ChatController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}