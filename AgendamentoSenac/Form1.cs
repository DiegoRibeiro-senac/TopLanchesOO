using System;
using System.Collections.Generic;
using System.ComponentModel; // Adicione esta linha
using System.Linq;
using System.Windows.Forms;

namespace AgendamentoSenac
{
    public partial class Form1 : Form
    {
        private BindingList<Ambiente> ambientes = new BindingList<Ambiente>(); // Use BindingList
        private BindingList<Instrutor> instrutores = new BindingList<Instrutor>(); // Use BindingList
        private object objetoSelecionado;

        public Form1()
        {
            InitializeComponent();
            cmbTipo.Items.AddRange(new string[] { "Ambiente", "Instrutor" });
            cmbTipo.SelectedIndex = 0;
            AtualizarDataGridView();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0) // Ambiente
                ambientes.Add(new Ambiente(txtNome.Text, txtTipoEspecialidade.Text));
            else // Instrutor
                instrutores.Add(new Instrutor(txtNome.Text, txtTipoEspecialidade.Text));
            AtualizarDataGridView();
            LimparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (objetoSelecionado != null)
            {
                if (objetoSelecionado is Ambiente)
                {
                    ((Ambiente)objetoSelecionado).Nome = txtNome.Text;
                    ((Ambiente)objetoSelecionado).Tipo = txtTipoEspecialidade.Text;
                }
                else
                {
                    ((Instrutor)objetoSelecionado).Nome = txtNome.Text;
                    ((Instrutor)objetoSelecionado).Especialidade = txtTipoEspecialidade.Text;
                }
                AtualizarDataGridView();
                LimparCampos();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (objetoSelecionado != null)
            {
                if (objetoSelecionado is Ambiente)
                    ambientes.Remove((Ambiente)objetoSelecionado);
                else
                    instrutores.Remove((Instrutor)objetoSelecionado);
                AtualizarDataGridView();
                LimparCampos();
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (cmbTipo.SelectedIndex == 0)
                    objetoSelecionado = ambientes[e.RowIndex];
                else
                    objetoSelecionado = instrutores[e.RowIndex];
                txtNome.Text = ObterNome(objetoSelecionado);
                txtTipoEspecialidade.Text = ObterTipoEspecialidade(objetoSelecionado);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            dgvDados.DataSource = null;
            if (cmbTipo.SelectedIndex == 0)
                dgvDados.DataSource = ambientes.Where(a => a.Nome.Contains(txtPesquisa.Text)).ToList();
            else
                dgvDados.DataSource = instrutores.Where(i => i.Nome.Contains(txtPesquisa.Text)).ToList();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtTipoEspecialidade.Clear();
            objetoSelecionado = null;
        }

        private string ObterNome(object obj) => obj is Ambiente ? ((Ambiente)obj).Nome : ((Instrutor)obj).Nome;
        private string ObterTipoEspecialidade(object obj) => obj is Ambiente ? ((Ambiente)obj).Tipo : ((Instrutor)obj).Especialidade;
    }
}