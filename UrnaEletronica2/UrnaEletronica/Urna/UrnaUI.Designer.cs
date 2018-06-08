namespace UrnaEletronica.Urna
{
    partial class UrnaUI
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
            this.lista_urnas = new System.Windows.Forms.DataGridView();
            this.voltar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.pesquisar = new System.Windows.Forms.Button();
            this.adicionar = new System.Windows.Forms.Button();
            this.zona_input = new System.Windows.Forms.TextBox();
            this.secao_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lista_urnas)).BeginInit();
            this.SuspendLayout();
            // 
            // lista_urnas
            // 
            this.lista_urnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_urnas.Location = new System.Drawing.Point(12, 12);
            this.lista_urnas.Name = "lista_urnas";
            this.lista_urnas.ReadOnly = true;
            this.lista_urnas.Size = new System.Drawing.Size(260, 142);
            this.lista_urnas.TabIndex = 21;
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(12, 233);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(117, 27);
            this.voltar.TabIndex = 19;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(202, 190);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(70, 27);
            this.excluir.TabIndex = 18;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // pesquisar
            // 
            this.pesquisar.Location = new System.Drawing.Point(202, 157);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(70, 27);
            this.pesquisar.TabIndex = 17;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(159, 233);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(113, 27);
            this.adicionar.TabIndex = 16;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // zona_input
            // 
            this.zona_input.Location = new System.Drawing.Point(12, 179);
            this.zona_input.MaxLength = 8;
            this.zona_input.Name = "zona_input";
            this.zona_input.Size = new System.Drawing.Size(76, 20);
            this.zona_input.TabIndex = 26;
            // 
            // secao_input
            // 
            this.secao_input.Location = new System.Drawing.Point(114, 179);
            this.secao_input.MaxLength = 8;
            this.secao_input.Name = "secao_input";
            this.secao_input.Size = new System.Drawing.Size(72, 20);
            this.secao_input.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Zona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Seção";
            // 
            // UrnaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zona_input);
            this.Controls.Add(this.secao_input);
            this.Controls.Add(this.lista_urnas);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.adicionar);
            this.Name = "UrnaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrnaUI";
            ((System.ComponentModel.ISupportInitialize)(this.lista_urnas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView lista_urnas;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.TextBox zona_input;
        private System.Windows.Forms.TextBox secao_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}