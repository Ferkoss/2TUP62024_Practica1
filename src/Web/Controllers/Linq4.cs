using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Linq4 : ControllerBase
{

    [HttpGet]
    public ActionResult Get()
    {
        List<int> lista=[78, -9, 0, 23, 54,  21, 7, 86];
        var retorno=lista.OrderByDescending(x=>x).Where((x,i)=>i<5);

        return Ok(retorno);
    }
}
