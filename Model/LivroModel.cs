using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiBiblioteca.Model
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroModel 
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 
        public string Autor { get; set; } = string.Empty; 
        public string Ano { get; set; } = string.Empty; 
        public int Quantidade { get; set; }
        public bool Alugado { get; set; }
    }
}
