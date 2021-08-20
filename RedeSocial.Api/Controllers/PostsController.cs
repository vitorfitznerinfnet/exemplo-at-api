using Microsoft.AspNetCore.Mvc;
using RedeSocial.Core;

namespace RedeSocial.Api.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        public PostsController(Aplicacao app)
        {
            App = app;
        }

        public Aplicacao App { get; }

        [HttpGet]
        public ActionResult Get()
        {
            var posts = App.ConsultarPosts();

            return Ok(posts);
        }
    }
}
