using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploContaBancariaPOO
{
    public partial class Form1 : Form
    {
        ContaBancaria conta = new ContaBancaria();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            

            double valor = double.Parse(txtSacar.Text);

            conta.Sacar(valor);
            AtualizarSaldo();

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            
            double valor = Double.Parse(txtDepositar.Text);

            conta.Depositar(valor);
            AtualizarSaldo();
        }

        private void AtualizarSaldo()
        {
            txtSaldo.Text = conta.Saldo.ToString();
        }
    }
}
