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
      Console.Clear();
      Console.WriteLine("Welcome to the Shack");
      //NOTE running method in Service to get items
      _bss.GetItems();
      //NOTE Adding the prompt
      Console.WriteLine();
      Console.WriteLine("Enter a number to see the burger or (Q)uit");
      //NOTE reading user response
      string userAns = Console.ReadLine().ToLower();

      //NOTE switch that takes user input and either quits the app or pulls up burger details
      switch (userAns)
      {
        case "q":
          Console.Clear();
          Environment.Exit(0);
          break;
        default:
          if (int.TryParse(userAns, out int index))
          {
            _bss.GetItem(index - 1);
            Console.ReadKey();
            Console.Clear();
          }
          else
          {
            Console.WriteLine("Invalid Selection");
          }
          break;
      }
    }
    public BurgerShackController()
    {
      // Console.WriteLine("Controller");
    }
  }
}