using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedeSocial.Core;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedeSocial.Api.Controllers
{
    [Route("api/pessoas")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post([FromBody] CadastrarPessoaRequest dados)
        {
            var app = new Aplicacao();

            app.CadastrarPessoa(dados.Nome, dados.Sobrenome, dados.Email, dados.Nascimento, dados.Senha);

            return Ok();
        }
    }
}
