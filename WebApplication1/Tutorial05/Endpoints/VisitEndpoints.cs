using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Endpoints;

public static class VisitEndpoints
{
    public static void MapVisitEndpoints(this WebApplication app)
    {
        //GET
        app.MapGet("/visits-minimalapi", (int id) =>
        {
            MockDb mockDb = new MockDb();
            var visits = mockDb.visitRepository.listOfVisitWithId(id);
            return Results.Ok(visits);
        });
        //POST
        app.MapPost("/visits-minimalapi", (Visit visit) =>
        {
            MockDb mockDb = new MockDb();
            mockDb.visitRepository.add(visit);
            return Results.Created("", visit);
        });
    }
}