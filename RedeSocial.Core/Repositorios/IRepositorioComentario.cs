using RedeSocial.Core.Entidades;
using System;

namespace RedeSocial.Core
{
    public interface IRepositorioComentario
    {
        void Salvar(Comentario post);
        Comentario BuscarComentarioPelo(Guid id);
        void Remover(Comentario comentario);
    }
}
