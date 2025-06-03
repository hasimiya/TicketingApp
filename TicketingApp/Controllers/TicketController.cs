using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TicketingApp.Models;
namespace TicketingApp.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Ticket()
        {
            return View();
        }
        public IActionResult TicketChat()
        {
            return View();
        }
        public IActionResult TicketCreate()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
