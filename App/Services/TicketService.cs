using System.Collections.Generic;
using TicketTracker.Models;

namespace TicketTracker.Services
{
  public class TicketService
  {
    public List<Ticket> Tickets { get; set; }
    public List<string> Messages { get; set; }


    public void GetTickets()
    {
      Messages.Add("Number \t Title");
      Messages.Add("_____________________________");
      for (int i = 0; i < Tickets.Count; i++)
      {
        Ticket t = Tickets[i];
        Messages.Add($"{i + 1}. \t {t.Name}");
      }
      Messages.Add("What would you like to do? (view / new / quit)");
    }

    public void CreateTickets(string infoName, string infoDescription)
    {
      Tickets.Add(new Ticket(infoName, infoDescription));
    }






    public TicketService()
    {
      Messages = new List<string>();
      Tickets = new List<Ticket>();
    }


  }
}