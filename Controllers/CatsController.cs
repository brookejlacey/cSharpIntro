namespace dotnetCats.Controllers;


[ApiController]
[Route("api/cats")]
public class CatsController : ControllerBase
{

    private readonly CatsService catsService;

    public CatsController(CatsService catsService)
    {
        this.catsService = catsService;
    }

    [HttpGet]
    public ActionResult<List<CatsController>> GetCats()
    {
        try
        {

        }
}

}