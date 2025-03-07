using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendamentoSenac
{
    public class Ambiente
    {
        public string Nome { get; set; }
        public string Tipo { get; set; } // Laboratório, Sala de Aula, etc.

        public Ambiente(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }
    }
}
