using System;

namespace RedeSocial.Core
{
    public class Pessoa
    {
        public string Nome { get; internal set; }
        public string Sobrenome { get; internal set; }
        public string Email { get; internal set; }
        public DateTime DataDeNascimento { get; internal set; }
        public string Senha { get; internal set; }
    }
}
