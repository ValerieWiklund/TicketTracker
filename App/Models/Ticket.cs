using TicketTracker.Interfaces;

namespace TicketTracker.Models
{
  public class Ticket : ITicket
  {

    public string Name { get; set; }
    public string Description { get; set; }


    public string GetTemplate()
    {
      return $@"
    Title: {Name} 
    Description: {Description}";
    }


    public Ticket(string name, string descr)
    {
      Name = name;
      Description = descr;

    }

  }
}