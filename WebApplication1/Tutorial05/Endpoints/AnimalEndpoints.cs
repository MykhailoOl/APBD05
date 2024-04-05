using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalsEndpoints(this WebApplication app)
    {
        //Minimal API
        //GET
        app.MapGet("/animals-minimalapi/{id}", (int id) =>
        {
            if (id != 1)
            {
                return Results.NotFound();
            }

            //process data
            return Results.Ok();
        });
        // 200 - ok
        // 201 - Created 
        // 400 - Bad Request
        // 404 - Not found
        //POST
        app.MapPost("/animals-minimalapi", (Animal animal) =>
        {
            // StaticData.animals.Add()
            var animals = new MockDb().Animals;
            return Results.Created("", animal);
        });
    }
}