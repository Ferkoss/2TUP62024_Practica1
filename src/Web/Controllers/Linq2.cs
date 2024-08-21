using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Linq2 : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(){
            List<String> palabras=["computadora", "usb"];
            var retorno =palabras.Where(x=>x.Length > 5).Select(x=>x.ToUpper());
            return Ok(retorno);
        }
    }
}
