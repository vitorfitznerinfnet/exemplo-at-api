using System;

namespace RedeSocial.Api.Controllers
{
    public class CadastrarPessoaRequest
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public string Senha { get; set; }
    }
}
