using System;
using burgershack.Services;

namespace burgershack.Controllers
{
  public class BurgerShackController
  {
    //NOTE property that calls the Service
    private BurgerShackService _bss { get; set; } = new BurgerShackService();

    //NOTE method to ask users questions and recieves answers
    public void UserResponse()
    {
      Console.WriteLine("Welcome to the Shack");
      //NOTE running method in Service to get items
      _bss.GetItems();
      Environment.Exit(0);
    }
    public BurgerShackController()
    {
      // Console.WriteLine("Controller");
    }
  }
}