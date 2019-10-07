namespace burgershack.Interfaces
{
    public interface IConsumable
    {
        int Calories { get; set; }
        int Fat { get; set; }
        int Protien { get; set; }
        int Carbohydrates { get; set; }
    }
}