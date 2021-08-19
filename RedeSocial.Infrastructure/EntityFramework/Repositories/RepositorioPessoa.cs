using RedeSocial.Core;
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

        public void Salvar(Pessoa pessoa)
        {
            BancoDeDados.Pessoa.Add(pessoa);
            BancoDeDados.SaveChanges();
        }
    }
}
