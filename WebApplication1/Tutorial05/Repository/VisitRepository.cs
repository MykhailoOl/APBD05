using WebApplication1.Models;

namespace WebApplication1.Database;

public class VisitRepository
{
    public List<Visit> visits = new List<Visit>();

    public void add(Visit visit)
    {
        visits.Add(visit);
    }

    public List<Visit> listOfVisitWithId(int id)
    {
        List<Visit> visitsWithId = visits.Where(v => v.animal.id == id).ToList();
        return visitsWithId;
    }
}