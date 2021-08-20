using Microsoft.EntityFrameworkCore;
using RedeSocial.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial.Infrastructure.EntityFramework
{
    public class RepositorioPessoa : IRepositorioPessoa
    {
        public RepositorioPessoa(BancoDeDados bancoDeDados)
        {
            BancoDeDados = bancoDeDados;
        }

        public BancoDeDados BancoDeDados { get; }

        public IEnumerable<Pessoa> Listar()
        {
            var pessoas = BancoDeDados.Pessoa.AsNoTracking().ToList();

            return pessoas;
        }

        public void Salvar(Pessoa pessoa)
        {
            BancoDeDados.Pessoa.Add(pessoa);
            BancoDeDados.SaveChanges();
        }
    }
}
