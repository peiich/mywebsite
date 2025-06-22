using Microsoft.AspNetCore.Mvc;

namespace _1111771.Controllers
{
    public class hw1Controller : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult prog1(int columns, int rows, string text)
    {
        ViewBag.Columns = columns;
        ViewBag.Rows = rows;
        ViewBag.Text = text;
        return View();
    }
}
}