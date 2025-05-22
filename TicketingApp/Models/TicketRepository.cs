using System.Collections.Generic;
using System.Linq;

namespace TicketingApp.Models
{
    public static class TicketRepository
    {
        public static List<TicketModel> listTicket = new List<TicketModel>()
        {
            new TicketModel{ Id = 19, Status = "Opened", Title = "The button doesn't work",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eleifend quis quam...", Publication = "19.02.2024"},
        new TicketModel{ Id = 23, Status = "Opened", Title = "I wanted to discuss the custom UI-kit",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eleifend quis quam...", Publication = "19.02.2024"},
        new TicketModel{ Id = 26, Status = "Solved", Title = "Why is cybersecurity important",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eleifend quis quam...", Publication = "19.02.2024"},
        new TicketModel{ Id = 12, Status = "Solved", Title = "Why is cybersecurity important",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eleifend quis quam...", Publication = "19.02.2024"},
        new TicketModel{ Id = 10, Status = "Solved", Title = "Why is cybersecurity important",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eleifend quis quam...", Publication = "19.02.2024"},
        new TicketModel{ Id = 15, Status = "Solved", Title = "Why is cybersecurity important",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eleifend quis quam...", Publication = "19.02.2024"},
        new TicketModel{ Id = 14, Status = "Opened", Title = "Why is cybersecurity important",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eleifend quis quam...", Publication = "19.02.2024"},
        new TicketModel{ Id = 13, Status = "Opened", Title = "Why is cybersecurity important",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eleifend quis quam...", Publication = "19.02.2024"}
        };
        public static List<TicketModel> GetAllTicket()
        {
            return listTicket;
        }
        public static void AddTicket(TicketModel ticket)
        {
            ticket.Id = listTicket.Max(x => x.Id) + 1;
            listTicket.Add(ticket);
        }
        public static List<TicketModel> GetOpenedTicket()
        {
            return listTicket.Where(x => x.Status == "Opened").ToList();
        }
        public static List<TicketModel> GetSolvedTicket()
        {
            return listTicket.Where(x => x.Status == "Solved").ToList();
        }
    }
}
