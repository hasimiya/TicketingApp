using Microsoft.AspNetCore.Mvc;
using TicketingApp.Models;

namespace TicketingApp.Components
{
    public class TicketViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string typeTicket)
        {
            var allTicket = TicketRepository.GetAllTicket();
            var openedTicket = TicketRepository.GetOpenedTicket();
            var solvedTicket = TicketRepository.GetSolvedTicket();

            if (string.IsNullOrEmpty(typeTicket) || typeTicket == "AllTicket")
            {
                return View(allTicket);
            }
            else if (typeTicket == "OpenedTicket")
            {
                return View(openedTicket);
            }
            else if (typeTicket == "SolvedTicket")
            {
                return View(solvedTicket);
            }
            return View();
        }
    }
}
