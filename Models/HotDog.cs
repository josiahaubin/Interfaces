using burgershack.Interfaces;
using burgershack.Models;

namespace Interfaces.Models
{
  public class HotDog : FoodItem, IPurchasable
  {
    public double BasePrice { get; set; }
    public HotDog(string name, int calories, int fat, int protein, int carbohydrates, double price) : base(name, calories, fat, protein, carbohydrates)
    {
      BasePrice = price;
    }

  }
}