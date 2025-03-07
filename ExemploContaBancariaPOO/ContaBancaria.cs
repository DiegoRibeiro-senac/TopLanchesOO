using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploContaBancariaPOO
{
    public class ContaBancaria
    {
        // Atributo privado
        private double saldo;

        // Propriedade pública para acessar o saldo
        public double Saldo
        {
            get { return saldo; }
        }

        // Métodos
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
            }
            else
            {
                MessageBox.Show("Saldo insuficiente.");
            }
        }
    }
}
