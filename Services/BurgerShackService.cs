using System;
using System.Collections.Generic;
using burgershack.Models;

namespace burgershack.Services
{
  public class BurgerShackService
  {

    //NOTE List of type string called messages
    public List<string> Messages { get; set; }
    //NOTE List of type Burger called Burgers
    public List<Burger> Burgers { get; set; }
    //NOTE List of type string Ingredients
    public List<string> Ingredients { get; set; }

    //NOTE Method called StartUp which creates our data
    public void StartUp()
    {
      //NOTE Adding Ingredients to the list
      Ingredients.Add("Lettuce");
      Ingredients.Add("Tomato");
      Ingredients.Add("Pickles");
      Ingredients.Add("Mayo");

      //NOTE Creating burgers
      Burger cheeseBurger = new Burger("Cheeze Burger", 2000, 50, 1000, 250, "Beef", 10.00, Ingredients);
      Burger baconCheeseBurger = new Burger("Bacon Cheeze Burger", 2500, 55, 1500, 125, "Beef", 11.00, Ingredients);
      Burger bisonBurger = new Burger("Bison Burger", 1500, 15, 1750, 100, "Bison", 15.00, Ingredients);

      //NOTE adding burgers to the burger list
      Burgers.AddRange(new Burger[] { cheeseBurger, baconCheeseBurger, bisonBurger });
    }

    //NOTE GetItems gets the Items from the Burger and Message list
    public void GetItems()
    {
      Messages.Add("Burgers:");
      for (int i = 0; i < Burgers.Count; i++)
      {
        Burger burger = Burgers[i];
        Messages.Add($"{i + 1}: {burger.Name} - Cals:{burger.Calories} - {burger.BasePrice:c}");
      }
      Print();
      Messages.Clear();
    }

    //NOTE GetItem gets the details of the specific burger the user selects
    public void GetItem(int index)
    {
      if (index > -1 && index < Burgers.Count)
      {
        Console.Clear();
        Burger burger = Burgers[index];
        Messages.Add(burger.GetTemplate());
        Print();
        Messages.Clear();

      }
      else
      {
        Console.WriteLine("Invalid Selection");
      }
    }

    //NOTE prints to the screen
    public void Print()
    {
      foreach (string message in Messages)
      {
        Console.WriteLine(message);
      }
    }
    public BurgerShackService()
    {
      //NOTE instantiating the lists
      Messages = new List<string>();
      Burgers = new List<Burger>();
      Ingredients = new List<string>();

      //NOTE creates our data when service is called
      StartUp();

      // Console.WriteLine("Service");
    }
  }
}