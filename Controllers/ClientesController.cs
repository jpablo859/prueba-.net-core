using Microsoft.AspNetCore.Mvc;
using System.Linq;
using webApi.Models;

namespace webApi.Controllers{
    [Route("api/[controller]")]
    public class ClientesController : Controller {
        private Conexion dbConexion;
        public ClientesController(){
            dbConexion = Conectar.Create(); 
        }
        [HttpGet]
        public ActionResult Get(){
            return Ok(dbConexion.Clientes.ToArray());
        }
    }
}