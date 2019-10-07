using System.Collections.Generic;
using burgershack.Interfaces;

namespace burgershack.Models
{
  public class Burger : FoodItem, IPurchasable, ISize
  {
    public string MeatType { get; set; }
    public double BasePrice { get; set; }
    public IEnumerable<string> Ingredients { get; set; }
    public double SizeMultiplier { get; set; }


    public double GetPrice(Size size)
    {
      return BasePrice + (SizeMultiplier * (int)size);
    }

    public override string GetTemplate()
    {
      string template = $@"
Burger: {Name}
Price: {BasePrice:c}
Meat:{MeatType}
Ingredients: {Ingredients}

Press any key to return to the Burger Menu
      ";

      return template;
    }


    public Burger(string name, int calories, int fat, int protein, int carbohydrates, string meat, double price, IEnumerable<string> ingredients) : base(name, calories, fat, protein, carbohydrates)
    {
      MeatType = meat;
      BasePrice = price;
      Ingredients = ingredients;
    }
  }
}