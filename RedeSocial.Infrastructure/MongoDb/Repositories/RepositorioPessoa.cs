using RedeSocial.Core;
using RedeSocial.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial.Infrastructure.MongoDb.Repositories
{
    public class RepositorioPessoa : IRepositorioPessoa
    {
        public IEnumerable<Pessoa> Listar()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
