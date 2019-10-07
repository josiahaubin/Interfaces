using System;
using burgershack.Controllers;

namespace burgershack
{
  class Program
  {
    static void Main(string[] args)
    {
      //NOTE this is connecting to the Controller
      BurgerShackController _bsc = new BurgerShackController();

      //NOTE  while loop true keeps running the program, infinite loop until I tell it to quit.
      while (true)
      {
        //NOTE calls the UserResponse method in the Controller
        _bsc.UserResponse();
      }
    }
  }
}
