using RedeSocial.Core;
using RedeSocial.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RedeSocial.Infrastructure.MongoDb.Repositories
{
    public class RepositorioPost : IRepositorioPost
    {
        public Post BuscarPostPelo(Guid idPost)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> BuscarPosts()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
