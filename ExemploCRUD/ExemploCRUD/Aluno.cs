using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCRUD
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"{Nome} ({Idade} anos)";
        }
    }
}
