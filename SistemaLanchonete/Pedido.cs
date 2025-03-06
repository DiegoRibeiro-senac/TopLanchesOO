using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLanchonete
{
    public class Pedido
    {
        // Lista para armazenar os itens do pedido.
        public List<ItemCardapio> Itens { get; set; } = new List<ItemCardapio>();

        // Propriedade para armazenar o valor total do pedido.
        public double TotalPedido { get; set; }

        // Propriedade para controlar o número do pedido.
        public int Cont { get; set; } = 1;

        // Método para adicionar um item ao pedido.
        public void AdicionarItem(ItemCardapio item)
        {
            // Verifica se o CheckBox do item está marcado.
            if (item.CheckBox.Checked == true)
            {
                // Se estiver marcado, adiciona o item à lista de itens do pedido.
                Itens.Add(item);
            }
        }

        // Método para calcular o valor total do pedido.
        public double CalcularTotal()
        {
            // Inicializa a variável total com 0.
            double total = 0;

            // Percorre a lista de itens do pedido.
            foreach (var item in Itens)
            {
                // Adiciona o valor total de cada item ao total geral.
                total += item.CalcularTotal();
            }

            // Retorna o valor total do pedido.
            return total;
        }

        // Método para limpar os itens do pedido (desmarcar os CheckBoxes).
        public void LimparItens()
        {
            // Criando uma cópia da lista para evitar modificar a coleção original durante a iteração, se fizer isso dá erro.
            // Isso é importante porque modificar a lista enquanto estamos percorrendo ela com o foreach causaria uma exceção.
            List<ItemCardapio> itensParaLimpar = new List<ItemCardapio>(Itens);

            // Percorre a lista de itens do pedido.
            foreach (var item in itensParaLimpar)
            {
                // Verifica se o CheckBox do item está marcado.
                if (item.CheckBox.Checked)
                {
                    // Se estiver marcado, desmarca o CheckBox.
                    item.CheckBox.Checked = false;
                }
            }
        }
    }
}