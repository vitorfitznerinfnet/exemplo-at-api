using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial.Core.Entidades
{
    public class Comentario
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public Guid AutorId { get; set; }
        public string Texto { get; set; }
        public DateTime DataPublicacao { get; set; }
    }
}
