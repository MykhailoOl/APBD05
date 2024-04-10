using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class Visit
{
    public int id { get; set; }
    public DateTime dateOfVisit { get; set; }
    public double price { get; set; }
    public string description { get; set; }
    public Animal animal { get; set; }

    public Visit(int id, DateTime dateOfVisit, double price, string description, Animal animal)
    {
        this.id = id;
        this.dateOfVisit = dateOfVisit;
        this.price = price;
        this.description = description;
        this.animal = animal;
    }
}