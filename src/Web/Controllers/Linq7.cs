using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Linq7 : ControllerBase
    {
        public static IList<string> DevolverPalabrasCapitales(string cadena){
            return cadena.Split(" ").Where(x=>string.Equals(x.ToUpper(),x)).ToList();
        }
        
        [HttpGet]
        public ActionResult Get(){
            return Ok(DevolverPalabrasCapitales("ESTO es un EJEMPLO del EJERcicio" ));
        }
    }
}
