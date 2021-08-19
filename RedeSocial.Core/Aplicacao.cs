using RedeSocial.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RedeSocial.Core
{
    public class Aplicacao
    {
        public IRepositorioPessoa RepositorioPessoa { get; }
        public IRepositorioPost RepositorioPost { get; }
        public IRepositorioComentario RepositorioComentario { get; }

        public Aplicacao(
            IRepositorioPessoa repositorioPessoa, 
            IRepositorioPost repositorioPost, 
            IRepositorioComentario repositorioComentario)
        {
            RepositorioPessoa = repositorioPessoa;
            RepositorioPost = repositorioPost;
            RepositorioComentario = repositorioComentario;
        }

        public void CadastrarPessoa(string nome, string sobrenome, string email, DateTime nascimento, string senha)
        {
            var pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.Sobrenome = sobrenome;
            pessoa.Email = email;
            pessoa.DataDeNascimento = nascimento;
            pessoa.Senha = senha;

            RepositorioPessoa.Salvar(pessoa);
        }

        public void CriarPost(string autor, string texto)
        {
            var post = new Post();
            post.Id = Guid.NewGuid();
            post.Autor = autor;
            post.Texto = texto;
            post.DataCriacao = DateTime.UtcNow;

            RepositorioPost.Salvar(post);
        }

        public string AdicionarComentario(Guid postId, Guid pessoaId, string texto)
        {
            if (!PostExiste(postId))
            {
                return "Post não existe";
            }
            
            var comentario = new Comentario();
            comentario.Id = Guid.NewGuid();
            comentario.AutorId = pessoaId;
            comentario.PostId = postId;
            comentario.DataPublicacao = DateTime.UtcNow;
            comentario.Texto = texto;

            RepositorioComentario.Salvar(comentario);

            return "OK";
        }

        private bool PostExiste(Guid postId)
        {
            var post = RepositorioPost.BuscarPostPelo(postId);

            return post != null;
        }

        public void RemoverComentario(Guid idComentario)
        {
            var comentario = RepositorioComentario.BuscarComentarioPelo(idComentario);

            RepositorioComentario.Remover(comentario);
        }

        public Post ConsultarPosts(Guid idPost)
        {
            var post = RepositorioPost.BuscarPostPelo(idPost);

            return post;
        }

        public IEnumerable<Post> ConsultarPosts()
        {
            var posts = RepositorioPost.BuscarPosts();

            return posts;
        }
    }
}
