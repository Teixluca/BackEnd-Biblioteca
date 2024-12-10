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
        public int Estoque { get; set; }
        public string? ImagemUrl { get; set; }

        public string AlugadosPara { get; set; } = string.Empty;
    }
}
