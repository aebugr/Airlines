using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesBugrina.Classes
{
    public class TicketContext : Ticket
    {
        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickets = new List<TicketContext>();
            return allTickets;
        }
    }
}
