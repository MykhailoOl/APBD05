using WebApplication1.Models;

namespace WebApplication1.Database;

public class AnimalRepository
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public List<Animal> getListOfAnimals()
    {
        return Animals;
    }

    public Animal getAnimalById(int id)
    {
        return Animals[id-1];
    }

    public void add(Animal animal)
    {
        Animals.Add(animal);
    }

    public void delete(Animal animal)
    {
        Animals.Remove(animal);
    }

    public void edit(Animal animal)
    {
        Animals[animal.id] = animal;
    }
}