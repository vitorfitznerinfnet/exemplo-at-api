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
        public IRepositorioPessoa RepositorioPessoa { get; }
        public IRepositorioPost RepositorioPost { get; }
        public IRepositorioComentario RepositorioComentario { get; }

        public ComentariosController(
            IRepositorioPessoa repositorioPessoa,
            IRepositorioPost repositorioPost,
            IRepositorioComentario repositorioComentario)
        {
            RepositorioPessoa = repositorioPessoa;
            RepositorioPost = repositorioPost;
            RepositorioComentario = repositorioComentario;
        }

        [HttpPost]
        public ActionResult Post(AdicionarComentarioRequest request)
        {
            var app = new Aplicacao(RepositorioPessoa, RepositorioPost, RepositorioComentario);

            var mensagem = app.AdicionarComentario(request.PostId, request.PessoaId, request.Texto);

            if (mensagem == "OK")
            {
                return Ok();
            }

            return BadRequest(mensagem);
        }
    }
}
