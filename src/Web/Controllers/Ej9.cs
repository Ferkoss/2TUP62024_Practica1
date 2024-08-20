using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace Web;



[ApiController]
[Route("[controller]")]
public class Ej9 : ControllerBase
{   


    [HttpGet]
    public ActionResult Get(int inicio,int fin){





  if (fin - inicio < 1000)
        {
            return BadRequest("La diferencia tiene que ser mayor a mil");
        }
        List<int> list=[];
        for(int i=0;i<=fin;i++){
            if(i%2==0){
                list.Add(i);
            }
        }
        return Ok(list);
    }}
