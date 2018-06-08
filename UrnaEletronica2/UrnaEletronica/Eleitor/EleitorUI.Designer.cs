namespace UrnaEletronica.Eleitor
{
    partial class EleitorUI
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
            this.lista_eleitores = new System.Windows.Forms.DataGridView();
            this.titulo_pesquisa_input = new System.Windows.Forms.TextBox();
            this.voltar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.pesquisar = new System.Windows.Forms.Button();
            this.adicionar = new System.Windows.Forms.Button();
            this.titulo_eleitor_excluir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lista_eleitores)).BeginInit();
            this.SuspendLayout();
            // 
            // lista_eleitores
            // 
            this.lista_eleitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_eleitores.Location = new System.Drawing.Point(12, 24);
            this.lista_eleitores.Name = "lista_eleitores";
            this.lista_eleitores.ReadOnly = true;
            this.lista_eleitores.Size = new System.Drawing.Size(260, 142);
            this.lista_eleitores.TabIndex = 14;
            // 
            // titulo_pesquisa_input
            // 
            this.titulo_pesquisa_input.Location = new System.Drawing.Point(12, 176);
            this.titulo_pesquisa_input.MaxLength = 11;
            this.titulo_pesquisa_input.Name = "titulo_pesquisa_input";
            this.titulo_pesquisa_input.Size = new System.Drawing.Size(192, 20);
            this.titulo_pesquisa_input.TabIndex = 13;
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(12, 255);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(117, 27);
            this.voltar.TabIndex = 12;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(202, 205);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(70, 27);
            this.excluir.TabIndex = 11;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // pesquisar
            // 
            this.pesquisar.Location = new System.Drawing.Point(202, 172);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(70, 27);
            this.pesquisar.TabIndex = 10;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(159, 255);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(113, 27);
            this.adicionar.TabIndex = 9;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // titulo_eleitor_excluir
            // 
            this.titulo_eleitor_excluir.Location = new System.Drawing.Point(12, 209);
            this.titulo_eleitor_excluir.MaxLength = 11;
            this.titulo_eleitor_excluir.Name = "titulo_eleitor_excluir";
            this.titulo_eleitor_excluir.Size = new System.Drawing.Size(192, 20);
            this.titulo_eleitor_excluir.TabIndex = 15;
            // 
            // EleitorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.titulo_eleitor_excluir);
            this.Controls.Add(this.lista_eleitores);
            this.Controls.Add(this.titulo_pesquisa_input);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.adicionar);
            this.Name = "EleitorUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EleitorUI";
            ((System.ComponentModel.ISupportInitialize)(this.lista_eleitores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lista_eleitores;
        private System.Windows.Forms.TextBox titulo_pesquisa_input;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.TextBox titulo_eleitor_excluir;
    }
}