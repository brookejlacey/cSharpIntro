
namespace dotnetCats.Services;

public class CatsService(CatsRepository repo)
{
    private readonly CatsRepository repo = repo;

    public readonly bool cool = true;
    private bool extraCool = false;

    internal List<Cat> GetCats()
    {
        List<Cat> cats = repo.GetCats();
        return cats;
    }



}