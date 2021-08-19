using System;
using System.Collections;
using System.Collections.Generic;

namespace RedeSocial.Core
{
    public interface IRepositorioPost
    {
        void Salvar(Post post);
        Post BuscarPostPelo(Guid idPost);
        IEnumerable<Post> BuscarPosts();
    }
}
