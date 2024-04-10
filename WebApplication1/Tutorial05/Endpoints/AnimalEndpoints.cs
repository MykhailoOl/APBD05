using Microsoft.AspNetCore.Mvc;
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
        app.MapGet("/animals-minimalapi", () =>
        {
            MockDb mockDb = new MockDb(); 
            var animals = mockDb.animalRepository.getListOfAnimals();
            return Results.Ok(animals);
        });
        //POST
        app.MapPost("/animals-minimalapi", ([FromBody]Animal animal) =>
        {
            MockDb mockDb = new MockDb();
            mockDb.animalRepository.add(animal);
            return Results.Created("", animal);
        });
        //PUT
        app.MapPut("/animals-minimalapi", ([FromBody]Animal animal) =>
        {
            MockDb mockDb = new MockDb();
            mockDb.animalRepository.edit(animal);
            return Results.Ok(animal);
        });
        //DELETE
        app.MapDelete("/animals-minimalapi", ([FromBody]Animal animal) =>
        {
            MockDb mockDb = new MockDb();
            mockDb.animalRepository.delete(animal);
            return Results.Ok();
        });
    }
}