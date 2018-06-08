namespace UrnaEletronica
{
    partial class PartidoUI
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
            this.adicionar = new System.Windows.Forms.Button();
            this.pesquisar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.number_partido_input = new System.Windows.Forms.TextBox();
            this.lista_partidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lista_partidos)).BeginInit();
            this.SuspendLayout();
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(212, 222);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(60, 27);
            this.adicionar.TabIndex = 3;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // pesquisar
            // 
            this.pesquisar.Location = new System.Drawing.Point(202, 182);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(70, 27);
            this.pesquisar.TabIndex = 4;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(115, 222);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(60, 27);
            this.excluir.TabIndex = 5;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(14, 222);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(60, 27);
            this.voltar.TabIndex = 6;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // number_partido_input
            // 
            this.number_partido_input.Location = new System.Drawing.Point(12, 186);
            this.number_partido_input.MaxLength = 2;
            this.number_partido_input.Name = "number_partido_input";
            this.number_partido_input.Size = new System.Drawing.Size(192, 20);
            this.number_partido_input.TabIndex = 7;
            this.number_partido_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_partido_input_KeyPress_1);
            // 
            // lista_partidos
            // 
            this.lista_partidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_partidos.Location = new System.Drawing.Point(12, 34);
            this.lista_partidos.Name = "lista_partidos";
            this.lista_partidos.ReadOnly = true;
            this.lista_partidos.Size = new System.Drawing.Size(260, 142);
            this.lista_partidos.TabIndex = 8;
            this.lista_partidos.SelectionChanged += new System.EventHandler(this.lista_partidos_SelectionChanged);
            // 
            // PartidoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lista_partidos);
            this.Controls.Add(this.number_partido_input);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.adicionar);
            this.Name = "PartidoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartidoUI";
            this.VisibleChanged += new System.EventHandler(this.update);
            ((System.ComponentModel.ISupportInitialize)(this.lista_partidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.TextBox number_partido_input;
        private System.Windows.Forms.DataGridView lista_partidos;
    }
}