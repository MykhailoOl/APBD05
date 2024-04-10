namespace WebApplication1.Models;

public class Animal
{
    public int id { get; set; }
    public string firstName { get; set; }
    public string category { get; set; }
    public double weight { get; set; }
    public string furColor { get; set; }

    public Animal(int id, string firstName, string category, double weight, string furColor)
    {
        this.id = id;
        this.firstName = firstName;
        this.category = category;
        this.weight = weight;
        this.furColor = furColor;
    }
}