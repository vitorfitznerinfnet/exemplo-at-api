using System;

namespace RedeSocial.Api.Controllers
{
    public class AdicionarComentarioRequest
    {
        public string Texto { get; set; }
        public Guid PostId { get; set; }
        public Guid PessoaId { get; set; }
    }
}
