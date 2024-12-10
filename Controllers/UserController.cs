using ApiBiblioteca.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
          
            private static List<UserModel> usuarios = new List<UserModel>();

        [HttpPost]
        public ActionResult<List<UserModel>> AdicionaUsuario(UserModel novo)
        {
   

            novo.IdUser = usuarios.Count < 0 ? usuarios[usuarios.Count - 1].IdUser + 1 : 1;

            usuarios.Add(novo);

            return Ok(usuarios);


        }

        [HttpGet]
        public ActionResult<List<UserModel>> BuscaUsuario()
        {
            return Ok(usuarios);
        }



    }
}
