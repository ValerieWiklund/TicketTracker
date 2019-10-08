using System;
using TicketTracker.Controllers;

namespace TicketTracker
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      TicketController tc = new TicketController();
      while (true)
      {
        tc.GetUserInput();
      }
    }
  }
}
