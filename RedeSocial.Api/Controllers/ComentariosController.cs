using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedeSocial.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedeSocial.Api.Controllers
{
    [Route("api/comentarios")]
    [ApiController]
    public class ComentariosController : ControllerBase
    {
        private Aplicacao _aplicacao;

        public ComentariosController(Aplicacao aplicacao)
        {
            _aplicacao = aplicacao;
        }

        [HttpPost]
        public ActionResult Post(AdicionarComentarioRequest request)
        {
            var mensagem = _aplicacao.AdicionarComentario(request.PostId, request.PessoaId, request.Texto);

            if (mensagem == "OK")
            {
                return Ok();
            }

            return BadRequest(mensagem);
        }
    }
}
