using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    //rota customizada
    [Route("api/product")]
    public class ProductController:Controller
    {
        //constraint
        /*[HttpGet("{id:int}")]
        public int Get(int id){
            return id;
        }*/
        
        //saber url que esta acessando
        /*public string Get(){
            return HttpContext.Request.Path;
        }*/

        //obter os parametos
        /*public string Get(){
            return HttpContext.Request.Query["param"];
        }*/

        //add response header
        /*public string Get(){

            HttpContext.Response.StatusCode = 404;

            HttpContext.Response.Headers.Add("ResponseHeader", "my response");
            return "ok";
        }*/

        //retorna pdf
        /*public IActionResult Get(){
            
            return Content("aaa", "application/pdf");
        }*/

        //retorna umagem
        public IActionResult Get(){
            
            return File("images/banner1.svg", "image/svg+xml");
        }

    }
}