namespace UrnaEletronica.Eleitor
{
    partial class EleitorCRUD
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
            this.label4 = new System.Windows.Forms.Label();
            this.data_nascimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.titulo_de_eleitor = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.zona = new System.Windows.Forms.ComboBox();
            this.secao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Seção";
            // 
            // data_nascimento
            // 
            this.data_nascimento.Location = new System.Drawing.Point(14, 135);
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.Size = new System.Drawing.Size(260, 20);
            this.data_nascimento.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Título de eleitor";
            // 
            // titulo_de_eleitor
            // 
            this.titulo_de_eleitor.Location = new System.Drawing.Point(14, 84);
            this.titulo_de_eleitor.Name = "titulo_de_eleitor";
            this.titulo_de_eleitor.Size = new System.Drawing.Size(260, 20);
            this.titulo_de_eleitor.TabIndex = 32;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(14, 173);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(32, 13);
            this.label.TabIndex = 31;
            this.label.Text = "Zona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Data nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(12, 35);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(260, 20);
            this.nome.TabIndex = 27;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(12, 224);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(122, 26);
            this.cancelar.TabIndex = 26;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(149, 224);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(122, 26);
            this.salvar.TabIndex = 25;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // zona
            // 
            this.zona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zona.FormattingEnabled = true;
            this.zona.Location = new System.Drawing.Point(14, 189);
            this.zona.Name = "zona";
            this.zona.Size = new System.Drawing.Size(83, 21);
            this.zona.TabIndex = 37;
            this.zona.SelectedIndexChanged += new System.EventHandler(this.zona_SelectedIndexChanged);
            // 
            // secao
            // 
            this.secao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secao.FormattingEnabled = true;
            this.secao.Location = new System.Drawing.Point(188, 189);
            this.secao.Name = "secao";
            this.secao.Size = new System.Drawing.Size(83, 21);
            this.secao.TabIndex = 38;
            // 
            // EleitorCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.secao);
            this.Controls.Add(this.zona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_nascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titulo_de_eleitor);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.salvar);
            this.Name = "EleitorCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EleitorCRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker data_nascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titulo_de_eleitor;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.ComboBox zona;
        private System.Windows.Forms.ComboBox secao;
    }
}