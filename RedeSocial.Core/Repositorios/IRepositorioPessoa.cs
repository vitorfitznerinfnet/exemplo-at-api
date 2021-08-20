using System.Collections.Generic;

namespace RedeSocial.Core
{
    public interface IRepositorioPessoa
    {
        void Salvar(Pessoa pessoa);
        IEnumerable<Pessoa> Listar();
    }
}
