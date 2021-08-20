using RedeSocial.Core;
using RedeSocial.Core.Entidades;
using System;

namespace RedeSocial.Infrastructure.EntityFramework
{
    public class RepositorioComentario : IRepositorioComentario
    {
        public RepositorioComentario(BancoDeDados bancoDeDados)
        {
            this.bancoDeDados = bancoDeDados;
        }

        public BancoDeDados bancoDeDados { get; }

        public Comentario BuscarComentarioPelo(Guid id)
        {
            return bancoDeDados.Comentario.Find(id);
        }

        public void Remover(Comentario comentario)
        {
            bancoDeDados.Remove(comentario);
            bancoDeDados.SaveChanges();
        }

        public void Salvar(Comentario comentario)
        {
            bancoDeDados.Comentario.Add(comentario);
            bancoDeDados.SaveChanges();
        }
    }
}
