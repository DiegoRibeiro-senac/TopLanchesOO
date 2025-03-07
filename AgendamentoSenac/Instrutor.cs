using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendamentoSenac
{
    public class Instrutor
    {
        public string Nome { get; set; }
        public string Especialidade { get; set; }

        public Instrutor(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }
    }
}
