namespace UrnaEletronica
{
    partial class CandidatoUI
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
            this.lista_candidatos = new System.Windows.Forms.DataGridView();
            this.nome_candidato_input = new System.Windows.Forms.TextBox();
            this.voltar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.pesquisar = new System.Windows.Forms.Button();
            this.adicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lista_candidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lista_candidatos
            // 
            this.lista_candidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_candidatos.Location = new System.Drawing.Point(11, 22);
            this.lista_candidatos.Name = "lista_candidatos";
            this.lista_candidatos.ReadOnly = true;
            this.lista_candidatos.Size = new System.Drawing.Size(260, 154);
            this.lista_candidatos.TabIndex = 9;
            this.lista_candidatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_candidatos_CellContentClick);
            // 
            // nome_candidato_input
            // 
            this.nome_candidato_input.Location = new System.Drawing.Point(11, 186);
            this.nome_candidato_input.MaxLength = 40;
            this.nome_candidato_input.Name = "nome_candidato_input";
            this.nome_candidato_input.Size = new System.Drawing.Size(192, 20);
            this.nome_candidato_input.TabIndex = 14;
            this.nome_candidato_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_candidato_input_KeyPress);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(13, 222);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(60, 27);
            this.voltar.TabIndex = 13;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(114, 222);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(60, 27);
            this.excluir.TabIndex = 12;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // pesquisar
            // 
            this.pesquisar.Location = new System.Drawing.Point(201, 182);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(70, 27);
            this.pesquisar.TabIndex = 11;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(211, 222);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(60, 27);
            this.adicionar.TabIndex = 10;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // CandidatoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nome_candidato_input);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.lista_candidatos);
            this.Name = "CandidatoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidatoUI";
            ((System.ComponentModel.ISupportInitialize)(this.lista_candidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lista_candidatos;
        private System.Windows.Forms.TextBox nome_candidato_input;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Button adicionar;
    }
}