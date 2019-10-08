using System;
using TicketTracker.Services;

namespace TicketTracker.Controllers
{
  public class TicketController
  {
    private TicketService _ts { get; set; } = new TicketService();
    public string Info;
    public void GetUserInput()
    {
      Console.WriteLine("Welcome to the Ticket System");
      _ts.GetTickets();
      Display();
      string choice = Console.ReadLine().ToLower();
      switch (choice)
      {
        case "q":
        case "quit":
        case "exit":
          Environment.Exit(0);
          break;
        case "new":
          GetTicketInfo();
          _ts.GetTickets();
          Display();

          break;
        case "view":
          Console.WriteLine("Which Ticket?");
          string input = Console.ReadLine();
          if (int.TryParse(input, out int index))
          {
            _ts.GetTickets(index - 1);
            Display();
            Console.WriteLine("Enter close to remove ticket or any other key to go back");
            string input2 = Console.ReadLine();
            if (input2 == "close")
            {
              _ts.DeleteTicket(index - 1);
            }
            else
            {
              GetUserInput();
            }
          }
          break;

      }
    }

    private void Display()
    {
      Console.Clear();
      foreach (string m in _ts.Messages)
      {
        Console.WriteLine(m);
      }
      _ts.Messages.Clear();
    }

    public void GetTicketInfo()
    {
      Console.WriteLine("Title:");
      string infoName = Console.ReadLine();
      Console.WriteLine("Description:");
      string infoDescription = Console.ReadLine();

      _ts.CreateTickets(infoName, infoDescription);
    }
  }
}