namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmCotacaoDolar
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
            this.txtQtdConversao = new System.Windows.Forms.TextBox();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.cmbMoedaDesejada = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtQtdConversao
            // 
            this.txtQtdConversao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtdConversao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdConversao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtdConversao.ForeColor = System.Drawing.Color.White;
            this.txtQtdConversao.Location = new System.Drawing.Point(23, 102);
            this.txtQtdConversao.Name = "txtQtdConversao";
            this.txtQtdConversao.PlaceholderText = "informe o valor em dólar";
            this.txtQtdConversao.Size = new System.Drawing.Size(207, 29);
            this.txtQtdConversao.TabIndex = 3;
            this.txtQtdConversao.TextChanged += new System.EventHandler(this.txtQtdConversao_TextChanged);
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimeiroValor.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(23, 27);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(0, 14);
            this.lblPrimeiroValor.TabIndex = 4;
            this.lblPrimeiroValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoValor.ForeColor = System.Drawing.Color.White;
            this.lblSegundoValor.Location = new System.Drawing.Point(23, 51);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(0, 26);
            this.lblSegundoValor.TabIndex = 6;
            this.lblSegundoValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMoedaDesejada
            // 
            this.cmbMoedaDesejada.FormattingEnabled = true;
            this.cmbMoedaDesejada.Items.AddRange(new object[] {
            "Dólar Americano",
            "Euro",
            "Libra Esterlinas"});
            this.cmbMoedaDesejada.Location = new System.Drawing.Point(323, 27);
            this.cmbMoedaDesejada.Name = "cmbMoedaDesejada";
            this.cmbMoedaDesejada.Size = new System.Drawing.Size(121, 23);
            this.cmbMoedaDesejada.TabIndex = 7;
            //this.cmbMoedaDesejada.SelectedIndexChanged += new System.EventHandler(this.cmbMoedaDesejada_SelectedIndexChanged);
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(455, 158);
            this.Controls.Add(this.cmbMoedaDesejada);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.txtQtdConversao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCotacaoDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCotacaoDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtQtdConversao;
        private Label lblPrimeiroValor;
        private Label lblSegundoValor;
        private MaskedTextBox maskedTextBox1;
        private ComboBox cmbMoedaDesejada;
    }
}