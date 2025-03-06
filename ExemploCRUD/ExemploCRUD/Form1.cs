using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploCRUD
{
    public partial class Form1 : Form
    {
        private List<Aluno> alunos = new List<Aluno>();
        private Aluno alunoSelecionado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = (int)numIdade.Value;

            Aluno aluno = new Aluno(nome, idade);
            alunos.Add(aluno);

            AtualizarListBox();
            LimparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (alunoSelecionado != null)
            {
                alunoSelecionado.Nome = txtNome.Text;
                alunoSelecionado.Idade = (int)numIdade.Value;

                AtualizarListBox();
                LimparCampos();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (alunoSelecionado != null)
            {
                alunos.Remove(alunoSelecionado);

                AtualizarListBox();
                LimparCampos();
            }
        }

        private void listBoxAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            alunoSelecionado = (Aluno)listBoxAlunos.SelectedItem;

            if (alunoSelecionado != null)
            {
                txtNome.Text = alunoSelecionado.Nome;
                numIdade.Value = alunoSelecionado.Idade;
            }
        }

        private void AtualizarListBox()
        {
            listBoxAlunos.DataSource = null;
            listBoxAlunos.DataSource = alunos;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            numIdade.Value = 0;
            alunoSelecionado = null;
        }
    }
}
