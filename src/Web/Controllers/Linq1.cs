using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Linq1 : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(){
        List<int> lista=[67, 92, 153, 15];
        var nuevaLista = lista.Where(x => x>30 && x<100).Select(x=>x);
        return Ok(nuevaLista);
        }
        }
}
