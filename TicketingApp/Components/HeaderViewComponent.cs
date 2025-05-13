using Microsoft.AspNetCore.Mvc;

namespace TicketingApp.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Default");
        }
    }
}
