using burgershack.Interfaces;

namespace burgershack.Models
{
  public abstract class FoodItem : IConsumable
  {
    public string Name { get; set; }
    public string Recipe { get; set; }
    public double CookTime { get; set; }
    public int Calories { get; set; }
    public int Fat { get; set; }
    public int Protein { get; set; }
    public int Carbohydrates { get; set; }


    public virtual string GetTemplate()
    {
      return "";
    }


    public FoodItem(string name, int calories, int fat, int protein, int carbohydrates)
    {
      Name = name;
      Calories = calories;
      Fat = fat;
      Protein = protein;
      Carbohydrates = carbohydrates;
    }
  }
}