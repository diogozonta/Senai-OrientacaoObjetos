namespace AplicacaoPoo.Estrutural.Windows
{
    partial class ProgramaUtilitario
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
            this.btnCotacao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCotacao
            // 
            this.btnCotacao.Location = new System.Drawing.Point(84, 45);
            this.btnCotacao.Name = "btnCotacao";
            this.btnCotacao.Size = new System.Drawing.Size(146, 44);
            this.btnCotacao.TabIndex = 0;
            this.btnCotacao.Text = "COTAÇÃO DO DOLAR";
            this.btnCotacao.UseVisualStyleBackColor = true;
            this.btnCotacao.Click += new System.EventHandler(this.btnCotacao_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "CONSULTA DE COMISSÃO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProgramaUtilitario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(322, 194);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCotacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProgramaUtilitario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa Utilitário";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCotacao;
        private Button button1;
    }
}