using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class TicketService
    {
        TicketDAO ticketDAO = new TicketDAO();

        public void CreateTicket(DateTime timeReported, string subject, TypeOfIncident typeOfIncident, string email, Priority priority, DateTime deadline, string description, bool finished)
        {
            Ticket ticket = new Ticket(timeReported, subject, typeOfIncident, email, priority, deadline, description, finished);
            ticketDAO.CreateTicket(ticket);
        }

        public List<Ticket> ReadTicketAll()
        {
            return ticketDAO.ReadTicketAll();
        }

        public List<Ticket> ReadTicketEmail(string email)
        {
            return ticketDAO.ReadTicketEmail(email);
        }
    }
}
