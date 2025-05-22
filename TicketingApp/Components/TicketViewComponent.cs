using Microsoft.AspNetCore.Mvc;
using TicketingApp.Models;

namespace TicketingApp.Components
{
    public class TicketViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var ticket = TicketRepository.GetAllTicket();
            return View(ticket);
        }
    }
}
