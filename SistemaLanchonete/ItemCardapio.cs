using System;
using System.Windows.Forms;

namespace SistemaLanchonete
{
    public class ItemCardapio
    {
        // Propriedades da classe para armazenar informações do item do cardápio
        public double PrecoUnitario { get; set; } // Preço unitário do item
        public int Quantidade { get; set; } // Quantidade do item (pode não ser usada diretamente aqui, mas em outros contextos)
        public CheckBox CheckBox { get; set; } // CheckBox associado ao item na interface gráfica
        public NumericUpDown NumericUpDown { get; set; } // NumericUpDown para controlar a quantidade do item
        public TextBox TextBoxTotal { get; set; } // TextBox para exibir o total do item
        public TextBox TextBoxPrecoUnitario { get; set; } // TextBox para exibir o preço unitário do item

        // Construtor da classe ItemCardapio
        public ItemCardapio(double precoUnitario, CheckBox checkBox, NumericUpDown numericUpDown, TextBox textBoxTotal, TextBox textBoxPrecoUnitario)
        {
            // Inicializa as propriedades com os valores passados como parâmetro

            PrecoUnitario = precoUnitario;
            CheckBox = checkBox;
            NumericUpDown = numericUpDown;
            TextBoxTotal = textBoxTotal;
            TextBoxPrecoUnitario = textBoxPrecoUnitario;

            // Associa os eventos CheckBox_CheckedChanged e NumericUpDown_ValueChanged aos controles correspondentes
            CheckBox.CheckedChanged += CheckBox_CheckedChanged;
            NumericUpDown.ValueChanged += NumericUpDown_ValueChanged;

            // Configura o estado inicial dos controles
            NumericUpDown.Enabled = false; // Desabilita o NumericUpDown no início
            TextBoxTotal.Enabled = false; // Desabilita o TextBoxTotal no início
            NumericUpDown.Value = 0; // Define o valor inicial do NumericUpDown como 0
            TextBoxTotal.Text = "0,00"; // Define o texto inicial do TextBoxTotal como "0,00"
        }

        // Método chamado quando o estado do CheckBox é alterado
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Habilita ou desabilita o NumericUpDown e o TextBoxTotal com base no estado do CheckBox
            NumericUpDown.Enabled = CheckBox.Checked;
            TextBoxTotal.Enabled = CheckBox.Checked;

            // Se o CheckBox for desmarcado
            if (!CheckBox.Checked)
            {
                // Reseta o valor do NumericUpDown e o texto do TextBoxTotal
                NumericUpDown.Value = 0;
                TextBoxTotal.Text = "0,00";

                // Remove o item do pedido chamando o método RemoverItemPedido do formulário principal
                ((frmPrincipal)CheckBox.FindForm()).RemoverItemPedido(this);
            }
            else
            {
                // Adiciona o item ao pedido chamando o método AdicionarItemPedido do formulário principal
                ((frmPrincipal)CheckBox.FindForm()).AdicionarItemPedido(this);
                NumericUpDown.Value = 1;
            }
        }

        // Método chamado quando o valor do NumericUpDown é alterado
        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Calcula o total do item multiplicando o valor do NumericUpDown pelo preço unitário
            double total = (double)NumericUpDown.Value * PrecoUnitario;

            // Exibe o total no TextBoxTotal formatado como moeda
            TextBoxTotal.Text = total.ToString("N2");

            // Atualiza o total do lanche chamando o método AtualizarTotalLanche do formulário principal
            ((frmPrincipal)NumericUpDown.FindForm()).AtualizarTotalLanche();
        }

        // Método para calcular o total do item
        public double CalcularTotal()
        {
            // Retorna o total do item multiplicando o valor do NumericUpDown pelo preço unitário
            return (double)NumericUpDown.Value * PrecoUnitario;
        }
    }
}