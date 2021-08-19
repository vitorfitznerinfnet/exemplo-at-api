using System;

namespace RedeSocial.Core
{
    public class Post
    {
        public Guid Id { get; internal set; }
        public string Autor { get; internal set; }
        public string Texto { get; internal set; }
        public DateTime DataCriacao { get; set; }
    }

    public static class PostExtension
    {
        public static void AlterarAutor(this Post post, string autor)
        {
            post.Autor = autor;
        }
    }
}
