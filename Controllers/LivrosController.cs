using Microsoft.AspNetCore.Mvc;
using ApiBiblioteca.Model;

namespace ApiBiblioteca.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class Biblioteca : ControllerBase
    {
        private static List<LivroModel> livros = new List<LivroModel>

        {
            new LivroModel {
                Id = 1,
                Name = "Dom Casmurro",
                Autor = "Machado de Assis",
                Ano = "1899",
                Quantidade = 2,
                Estoque = 2,
                AlugadosPara = "",
                ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/dom_casmurro_edicao_de_luxo_almofadada_89_1_038fb70c564eb50f71ea49f6027e827a.jpg"
            },
            new LivroModel
            {
                Id = 2,
                Name = "Memórias Póstumas de Brás Cubas",
                Autor = "Machado de Assis",
                Ano = "1881",
                Quantidade = 3,
                Estoque = 3,
                ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/memorias_postumas_de_bras_cubas_187_1_c5d670beb52b5ef67fbede0220256c2d.jpg"
            },
            new LivroModel
            {
                Id = 3,
                Name = "Grande Sertão: Veredas",
                Autor = "João Guimarães Rosa",
                Ano = "1956",
                Quantidade = 4,
                Estoque = 4,
                ImagemUrl = "https://books.google.com.br/books/publisher/content?id=s9kiEAAAQBAJ&hl=pt-BR&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U1IlISKVium_w1Szw6kSCNbu9vK4w&w=1280"
            },
            new LivroModel
            {
                Id = 4,
                Name = "O Cortiço",
                Autor = "Aluísio Azevedo",
                Ano = "1890",
                Quantidade = 4,
                Estoque = 4,
                ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/o_cortico_235_1_fa14cd7501c357c31895dfe698838be3.jpg"
            },
            new LivroModel
            {
                Id = 5,
                Name = "Iracema",
                Autor = "José de Alencar",
                Ano = "1865",
                Quantidade = 1,
                Estoque = 1,
                ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/iracema_2837_1_40d78d241322fc49bbc0bbb97e522a9a.jpg"
            },
            new LivroModel
            {
                Id = 6,
                Name = "Macunaíma",
                Autor = "Mário de Andrade",
                Ano = "1928",
                Quantidade = 11,
                Estoque = 11,
                ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/macunaima_2845_1_745f6996a75c01bd4c1ba780ea44ab6a.jpg"
            },
            new LivroModel
            {
                Id = 7,
                Name = "Capitães da Areia",
                Autor = "Jorge Amado",
                Ano = "1937",
                Quantidade = 2,
                Estoque = 2,
                ImagemUrl = "https://books.google.com.br/books/content?id=FDJ1_r4MCIEC&hl=pt-BR&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U3zJno2Uga1FTYiRQ7ScgopvGEHjQ&w=1280"
            },
            new LivroModel
            {
                Id = 8,
                Name = "Vidas Secas",
                Autor = "Graciliano Ramos",
                Ano = "1938",
                Quantidade = 9,
                Estoque = 9,
                ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/vidas_secas_45_1_b309cd9d843c7c948ed1a456f6e8eada.jpg"
            },
            new LivroModel
            {
                Id = 9,
                Name = "A Moreninha",
                Autor = "Joaquim Manuel de Macedo",
                Ano = "1844",
                Quantidade = 2,
                Estoque = 2,
                ImagemUrl = "https://books.google.com.br/books/publisher/content?id=RL2kEAAAQBAJ&hl=pt-BR&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U2yGtRhpTPgCc5ytlGNkRU7ETTlTQ&w=1280"
            },
            new LivroModel
            {
                Id = 10,
                Name = "O Tempo e o Vento",
                Autor = "Erico Verissimo",
                Ano = "1949",
                Quantidade = 1,
                Estoque = 1,
                ImagemUrl = "https://m.media-amazon.com/images/I/51lV89906rL._SY445_SX342_.jpg"
            },
            new LivroModel
            {
                Id = 11,
                Name = "A Hora da Estrela",
                Autor = "Clarice Lispector",
                Ano = "1977",
                Quantidade = 1,
                Estoque = 1,
                ImagemUrl = "https://books.google.com.br/books/publisher/content?id=EcgOEAAAQBAJ&hl=pt-BR&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U350lvnhB_33MY-9gN_xl6p2lM0Ng&w=1280"
            },
            new LivroModel
            {
                Id = 12,
                Name = "O Quinze",
                Autor = "Rachel de Queiroz",
                Ano = "1930",
                Quantidade = 1,
                Estoque = 1,
                ImagemUrl = "https://m.media-amazon.com/images/I/512O2V7xRjL._SY445_SX342_.jpg"
            },
            new LivroModel
            {
                Id = 13,
                Name = "Menino do Engenho",
                Autor = "José Lins do Rego",
                Ano = "1932",
                Quantidade = 5,
                Estoque = 5,
                ImagemUrl = "https://m.media-amazon.com/images/I/71SkheXF9VL._SY466_.jpg"
            },
            new LivroModel
            {
                Id = 14,
                Name = "Sagarana",
                Autor = "João Guimarães Rosa",
                Ano = "1946",
                Quantidade = 3,
                Estoque = 3,
                ImagemUrl = "https://m.media-amazon.com/images/I/81VvCG8xXWL._SY522_.jpg"
            },
            new LivroModel
            {
                Id = 15,
                Name = "Fogo Morto",
                Autor = "José Lins do Rego",
                Ano = "1943",
                Quantidade = 1,
                Estoque = 1,
                ImagemUrl = "https://m.media-amazon.com/images/I/51SM+a8FuyL._SY445_SX342_.jpg"
            },

    };
        [HttpGet]
        public ActionResult<List<LivroModel>> VerLivros()
        {
            return Ok(livros);
        }


        [HttpGet("{id}")]
        public ActionResult<LivroModel>
            StatusLivro(int id)
        {
            var pesquisa = livros.Find(x => x.Id == id);
            if (id == 0 || pesquisa is null)
            {
                return NotFound("Este Livro não foi encontrado");
            }
            return Ok(pesquisa);
        }

        // API para devolver o livro
        [HttpPost("devolve/{id}")]
        public ActionResult<LivroModel>
            DevolverLivros(int id)
        {
            var pesquisa = livros.Find(x => x.Id == id);

            if (pesquisa is null)
            {
                return NotFound("Livro não existe");
            }


            if (pesquisa.Quantidade >= pesquisa.Estoque)
            {
                return NotFound("Quantidade maior que estoque");
            }

            pesquisa.Quantidade++;


            return Ok(pesquisa);

        }


        // API para alugar o livro
        [HttpPost("aluga/{id}")]
        public ActionResult<List<LivroModel>>
            AlugarLivros(int id)
        {
            var pesquisa = livros.Find(x => x.Id == id);


            if (pesquisa is null)
            {
                return NotFound("Livro não encontrado");
            }


            if (pesquisa.Quantidade == 0)
            {
                return NotFound("Livro esgotado");
            }


            pesquisa.Quantidade--;

            return Ok(pesquisa);

        }



        [HttpPost]
        public ActionResult<LivroModel> AddLivro(LivroModel novo)
            {
               if (novo.Id == 0 && livros.Count >0) 
                novo.Id = livros[livros.Count - 1].Id + 1;

               livros.Add(novo);
               return Ok(novo);
            }

    }
}