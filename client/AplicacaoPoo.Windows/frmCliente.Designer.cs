namespace AplicacaoPoo.Windows
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblValorCredito = new System.Windows.Forms.Label();
            this.lblValorDebito = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtValorDebito = new System.Windows.Forms.TextBox();
            this.txtValorCredito = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldoIniciarValor = new System.Windows.Forms.Label();
            this.lblSaldoValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(15, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "NOME:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(159, 9);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 21);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF:";
            // 
            // lblValorCredito
            // 
            this.lblValorCredito.AutoSize = true;
            this.lblValorCredito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorCredito.Location = new System.Drawing.Point(159, 87);
            this.lblValorCredito.Name = "lblValorCredito";
            this.lblValorCredito.Size = new System.Drawing.Size(125, 21);
            this.lblValorCredito.TabIndex = 2;
            this.lblValorCredito.Text = "Valor de Crédito:";
            // 
            // lblValorDebito
            // 
            this.lblValorDebito.AutoSize = true;
            this.lblValorDebito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorDebito.Location = new System.Drawing.Point(5, 88);
            this.lblValorDebito.Name = "lblValorDebito";
            this.lblValorDebito.Size = new System.Drawing.Size(120, 21);
            this.lblValorDebito.TabIndex = 3;
            this.lblValorDebito.Text = "Valor de Débito:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 4;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(159, 33);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 23);
            this.txtCpf.TabIndex = 5;
            // 
            // txtValorDebito
            // 
            this.txtValorDebito.Location = new System.Drawing.Point(15, 112);
            this.txtValorDebito.Name = "txtValorDebito";
            this.txtValorDebito.Size = new System.Drawing.Size(100, 23);
            this.txtValorDebito.TabIndex = 6;
            // 
            // txtValorCredito
            // 
            this.txtValorCredito.Location = new System.Drawing.Point(159, 112);
            this.txtValorCredito.Name = "txtValorCredito";
            this.txtValorCredito.Size = new System.Drawing.Size(100, 23);
            this.txtValorCredito.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(159, 154);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 35);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Saldo Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(311, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Saldo Final";
            // 
            // lblSaldoIniciarValor
            // 
            this.lblSaldoIniciarValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldoIniciarValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoIniciarValor.Location = new System.Drawing.Point(311, 33);
            this.lblSaldoIniciarValor.Name = "lblSaldoIniciarValor";
            this.lblSaldoIniciarValor.Size = new System.Drawing.Size(86, 23);
            this.lblSaldoIniciarValor.TabIndex = 11;
            this.lblSaldoIniciarValor.Text = "0";
            this.lblSaldoIniciarValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaldoValor
            // 
            this.lblSaldoValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldoValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoValor.Location = new System.Drawing.Point(311, 112);
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(86, 23);
            this.lblSaldoValor.TabIndex = 12;
            this.lblSaldoValor.Text = "0";
            this.lblSaldoValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 201);
            this.Controls.Add(this.lblSaldoValor);
            this.Controls.Add(this.lblSaldoIniciarValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorCredito);
            this.Controls.Add(this.txtValorDebito);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblValorDebito);
            this.Controls.Add(this.lblValorCredito);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblCpf;
        private Label lblValorCredito;
        private Label lblValorDebito;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtValorDebito;
        private TextBox txtValorCredito;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label lblSaldoIniciarValor;
        private Label lblSaldoValor;
    }
}