namespace ExemploContaBancariaPOO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepositar = new System.Windows.Forms.TextBox();
            this.txtSacar = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deposito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saque";
            // 
            // txtDepositar
            // 
            this.txtDepositar.Location = new System.Drawing.Point(134, 85);
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(100, 26);
            this.txtDepositar.TabIndex = 2;
            // 
            // txtSacar
            // 
            this.txtSacar.Location = new System.Drawing.Point(134, 194);
            this.txtSacar.Name = "txtSacar";
            this.txtSacar.Size = new System.Drawing.Size(100, 26);
            this.txtSacar.TabIndex = 3;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(240, 188);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(97, 39);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(240, 79);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(97, 39);
            this.btnDepositar.TabIndex = 5;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(410, 118);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 26);
            this.txtSaldo.TabIndex = 7;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.txtSacar);
            this.Controls.Add(this.txtDepositar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepositar;
        private System.Windows.Forms.TextBox txtSacar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaldo;
    }
}

