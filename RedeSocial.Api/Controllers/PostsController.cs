using Microsoft.AspNetCore.Mvc;
using RedeSocial.Core;

namespace RedeSocial.Api.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            var app = new Aplicacao();

            var posts = app.ConsultarPosts();

            return Ok(posts);
        }
    }
}
