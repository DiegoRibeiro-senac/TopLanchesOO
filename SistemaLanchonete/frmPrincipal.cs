using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaLanchonete
{
    public partial class frmPrincipal : Form
    {
        // Instância da classe Pedido para gerenciar os itens do pedido
        private Pedido pedido = new Pedido();

        // Lista para armazenar os itens do cardápio
        private List<ItemCardapio> itensCardapio = new List<ItemCardapio>();

        // Construtor do formulário principal
        public frmPrincipal()
        {
            // Inicializa os componentes do formulário
            InitializeComponent();

            // Inicializa os itens do cardápio
            InicializarItensCardapio();
        }

        // Método para inicializar os itens do cardápio
        private void InicializarItensCardapio()
        {
            // Cria instâncias de ItemCardapio e adiciona à lista itensCardapio
            itensCardapio.Add(new ItemCardapio("Hamburger", Convert.ToDouble(txtUniHamburger.Text), cbHamburger, numHamburger, txtTotalHamburger, txtUniHamburger));
            itensCardapio.Add(new ItemCardapio("Ovo", Convert.ToDouble(txtUniOvo.Text), cbOvo, numOvo, txtTotalOvo, txtUniOvo));
            itensCardapio.Add(new ItemCardapio("Presunto", Convert.ToDouble(txtUniPresunto.Text), cbPresunto, numPresunto, txtTotalPresunto, txtUniPresunto));
            itensCardapio.Add(new ItemCardapio("Mussarela", Convert.ToDouble(txtUniMussarela.Text), cbMussarela, numMussarela, txtTotalMussarela, txtUniMussarela));
            itensCardapio.Add(new ItemCardapio("Bacon", Convert.ToDouble(txtUniBacon.Text), cbBacon, numBacon, txtTotalBacon, txtUniBacon));
            itensCardapio.Add(new ItemCardapio("Frango", Convert.ToDouble(txtUniFrango.Text), cbFrango, numFrango, txtTotalFrango, txtUniFrango));
            itensCardapio.Add(new ItemCardapio("Alface", Convert.ToDouble(txtUniAlface.Text), cbAlface, numAlface, txtTotalAlface, txtUniAlface));
            itensCardapio.Add(new ItemCardapio("Tomate", Convert.ToDouble(txtUniTomate.Text), cbTomate, numTomate, txtTotalTomate, txtUniTomate));
            itensCardapio.Add(new ItemCardapio("Milho", Convert.ToDouble(txtUniMilho.Text), cbMilho, numMilho, txtTotalMilho, txtUniMilho));
            itensCardapio.Add(new ItemCardapio("Ervilha", Convert.ToDouble(txtUniErvilha.Text), cbErvilha, numErvilha, txtTotalErvilha, txtUniErvilha));
        }

        // Método para atualizar o total do lanche exibido na interface
        public void AtualizarTotalLanche()
        {
            // Calcula o total do pedido usando o método CalcularTotal da classe Pedido
            // e exibe no TextBox txtTotalLanche formatado como moeda
            txtTotalLanche.Text = pedido.CalcularTotal().ToString("N2");
        }

        // Evento chamado quando o botão btnAddLanche é clicado
        private void btnAddLanche_Click(object sender, EventArgs e)
        {
            // Adiciona o lanche à ListBox lbLaches com o número do pedido e o valor total
            lbLaches.Items.Add("Lanche " + pedido.Cont + ": R$ " + txtTotalLanche.Text);

            // Incrementa o contador de pedidos
            pedido.Cont++;

            // Adiciona o valor total do lanche ao total do pedido
            pedido.TotalPedido += Convert.ToDouble(txtTotalLanche.Text);

            // Exibe o total do pedido no TextBox txtValorPedido formatado como moeda
            txtValorPedido.Text = pedido.TotalPedido.ToString("N2");

            // Limpa os itens do pedido (desmarca os CheckBoxes)
            pedido.LimparItens();

            // Atualiza o total do lanche
            AtualizarTotalLanche();
        }

        // Evento chamado quando o botão btnFinalizarPedido é clicado
        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            // Calcula o troco subtraindo o total do pedido do valor recebido
            double troco = Convert.ToDouble(txtValorRecebido.Text) - pedido.TotalPedido;

            // Exibe o troco no TextBox txtTroco formatado como moeda
            txtTroco.Text = troco.ToString("N2");

            // Exibe uma mensagem de pedido realizado com sucesso
            MessageBox.Show("Pedido realizado com sucesso!", "Finalizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpa os itens do pedido
            pedido.LimparItens();

            // Limpa a ListBox de lanches
            lbLaches.Items.Clear();

            // Reseta os TextBoxes de valor do pedido, valor recebido e troco
            txtValorPedido.ResetText();
            txtValorRecebido.ResetText();
            txtTroco.ResetText();

            // Reseta o contador de pedidos e o total do pedido
            pedido.Cont = 1;
            pedido.TotalPedido = 0;

            // Atualiza o total do lanche
            AtualizarTotalLanche();
        }

        // Método para adicionar um item ao pedido
        public void AdicionarItemPedido(ItemCardapio item)
        {
            // Adiciona o item ao pedido usando o método AdicionarItem da classe Pedido
            pedido.AdicionarItem(item);

            // Atualiza o total do lanche
            AtualizarTotalLanche();
        }

        // Método para remover um item do pedido
        public void RemoverItemPedido(ItemCardapio item)
        {
            // Remove o item do pedido usando o método Remove da lista Itens da classe Pedido
            pedido.Itens.Remove(item);

            // Atualiza o total do lanche
            AtualizarTotalLanche();
        }
    }
}