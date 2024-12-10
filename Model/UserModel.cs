using Microsoft.AspNetCore.Mvc;

namespace ApiBiblioteca.Model
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserModel
    {
        public int IdUser { get; set; }
        public int Id { get; set; }
        public string NameUser { get; set; } = string.Empty;
        public string EmailUser{ get; set; } = string.Empty;
        public string AnoNasc { get; set; } = string.Empty;
    }
}
