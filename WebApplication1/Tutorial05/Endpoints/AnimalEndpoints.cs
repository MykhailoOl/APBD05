using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalsEndpoints(this WebApplication app)
    {
        //Minimal API
        // 200 - ok
        // 201 - Created 
        // 400 - Bad Request
        // 404 - Not found
        //GET
        app.MapGet("/animals-minimalapi/{id}", (int id) =>
        {
            MockDb mockDb = new MockDb();
            return Results.Ok(mockDb.animalRepository.getAnimalById(id));
        });
        app.MapGet("/animals-minimalapi", (MockDb mockDb) =>
        {
            var animals = mockDb.animalRepository.getListOfAnimals();
            return Results.Ok(animals);
        });
        app.MapGet("/visits-minimalapi", (int id) =>
        {
            MockDb mockDb = new MockDb();
            var visits = mockDb.visitRepository.listOfVisitWithId(id);
            return Results.Ok(visits);
        });
        //POST
        app.MapPost("/animals-minimalapi", (Animal animal) =>
        {
            MockDb mockDb = new MockDb();
            mockDb.animalRepository.add(animal);
            return Results.Created("", animal);
        });
        app.MapPost("/visits-minimalapi", (Visit visit) =>
        {
            MockDb mockDb = new MockDb();
            mockDb.visitRepository.add(visit);
            return Results.Created("", visit);
        });
        //PUT
        app.MapPut("/animals-minimalapi", (Animal animal) =>
        {
            MockDb mockDb = new MockDb();
            mockDb.animalRepository.edit(animal);
            return Results.Ok(animal);
        });
        //DELETE
        app.MapDelete("/visits-minimalapi", (Animal animal) =>
        {
            MockDb mockDb = new MockDb();
            mockDb.animalRepository.delete(animal);
            return Results.Ok();
        });
    }
}