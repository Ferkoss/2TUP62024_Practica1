using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Linq5 : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(){
            List <int> num= [7, 2, 30];
            var numCuadrado=num.Where(x=>x*x>20).Select(x=>$"{x} - {x*x}");
            return Ok(numCuadrado);
        }
    }
}
