using RedeSocial.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RedeSocial.Infrastructure.EntityFramework
{
    public class RepositorioPost : IRepositorioPost
    {
        public RepositorioPost(BancoDeDados bancoDeDados)
        {
            BancoDeDados = bancoDeDados;
        }

        public BancoDeDados BancoDeDados { get; }

        public Post BuscarPostPelo(Guid idPost)
        {
            return BancoDeDados.Post.Find(idPost);
        }

        public IEnumerable<Post> BuscarPosts()
        {
            return BancoDeDados.Post.Where(x => x.DataCriacao > DateTime.Now.AddDays(-1).Date);
        }

        public void Salvar(Post post)
        {
            BancoDeDados.Post.Add(post);
            BancoDeDados.SaveChanges();
        }
    }
}
