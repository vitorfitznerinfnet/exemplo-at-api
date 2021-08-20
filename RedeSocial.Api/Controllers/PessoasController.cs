using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedeSocial.Core;
using RedeSocial.Infrastructure.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedeSocial.Api.Controllers
{
    [Route("api/pessoas")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        public PessoasController(Aplicacao aplicacao)
        {
            _aplicacao = aplicacao;
        }

        private Aplicacao _aplicacao;

        [HttpPost]
        public ActionResult Post([FromBody] CadastrarPessoaRequest dados)
        {
            _aplicacao.CadastrarPessoa(dados.Nome, dados.Sobrenome, dados.Email, dados.Nascimento, dados.Senha);

            return Ok();
        }

        [HttpGet]
        public ActionResult Get()
        {
            var pessoas = _aplicacao.ConsultarPessoas();

            return Ok(pessoas);
        }
    }
}
