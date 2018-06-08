namespace UrnaEletronica.Candidato
{
    partial class CandidatoCRUD
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
            this.codigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codigo_candidato = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.salvar_cand = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data_nascimento = new System.Windows.Forms.DateTimePicker();
            this.partido_combo_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.tipo_candidato = new System.Windows.Forms.ComboBox();
            this.vice_prefeito = new System.Windows.Forms.ComboBox();
            this.vice_prefeito_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(14, 210);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(40, 13);
            this.codigo.TabIndex = 15;
            this.codigo.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Data nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // codigo_candidato
            // 
            this.codigo_candidato.Location = new System.Drawing.Point(13, 226);
            this.codigo_candidato.MaxLength = 5;
            this.codigo_candidato.Name = "codigo_candidato";
            this.codigo_candidato.Size = new System.Drawing.Size(61, 20);
            this.codigo_candidato.TabIndex = 12;
            this.codigo_candidato.TextChanged += new System.EventHandler(this.codigo_candidato_TextChanged);
            this.codigo_candidato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_candidato_KeyPress);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(13, 78);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(260, 20);
            this.nome.TabIndex = 10;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(12, 262);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(122, 26);
            this.cancelar.TabIndex = 9;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // salvar_cand
            // 
            this.salvar_cand.Location = new System.Drawing.Point(149, 262);
            this.salvar_cand.Name = "salvar_cand";
            this.salvar_cand.Size = new System.Drawing.Size(122, 26);
            this.salvar_cand.TabIndex = 8;
            this.salvar_cand.Text = "Salvar";
            this.salvar_cand.UseVisualStyleBackColor = true;
            this.salvar_cand.Click += new System.EventHandler(this.salvar_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(13, 126);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(260, 20);
            this.email.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "E-mail";
            // 
            // data_nascimento
            // 
            this.data_nascimento.Location = new System.Drawing.Point(13, 171);
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.Size = new System.Drawing.Size(260, 20);
            this.data_nascimento.TabIndex = 18;
            // 
            // partido_combo_box
            // 
            this.partido_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partido_combo_box.FormattingEnabled = true;
            this.partido_combo_box.Location = new System.Drawing.Point(151, 225);
            this.partido_combo_box.Name = "partido_combo_box";
            this.partido_combo_box.Size = new System.Drawing.Size(121, 21);
            this.partido_combo_box.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Partido";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(9, 9);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(28, 13);
            this.tipo.TabIndex = 21;
            this.tipo.Text = "Tipo";
            // 
            // tipo_candidato
            // 
            this.tipo_candidato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_candidato.FormattingEnabled = true;
            this.tipo_candidato.Location = new System.Drawing.Point(12, 25);
            this.tipo_candidato.Name = "tipo_candidato";
            this.tipo_candidato.Size = new System.Drawing.Size(100, 21);
            this.tipo_candidato.TabIndex = 22;
            this.tipo_candidato.SelectedIndexChanged += new System.EventHandler(this.tipo_candidato_SelectedIndexChanged);
            // 
            // vice_prefeito
            // 
            this.vice_prefeito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vice_prefeito.FormattingEnabled = true;
            this.vice_prefeito.Location = new System.Drawing.Point(151, 25);
            this.vice_prefeito.Name = "vice_prefeito";
            this.vice_prefeito.Size = new System.Drawing.Size(120, 21);
            this.vice_prefeito.TabIndex = 23;
            this.vice_prefeito.Visible = false;
            this.vice_prefeito.SelectedIndexChanged += new System.EventHandler(this.prefeito_SelectedIndexChanged);
            // 
            // vice_prefeito_label
            // 
            this.vice_prefeito_label.AutoSize = true;
            this.vice_prefeito_label.Location = new System.Drawing.Point(148, 9);
            this.vice_prefeito_label.Name = "vice_prefeito_label";
            this.vice_prefeito_label.Size = new System.Drawing.Size(66, 13);
            this.vice_prefeito_label.TabIndex = 24;
            this.vice_prefeito_label.Text = "Vice prefeito";
            this.vice_prefeito_label.Visible = false;
            // 
            // CandidatoCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.vice_prefeito_label);
            this.Controls.Add(this.vice_prefeito);
            this.Controls.Add(this.tipo_candidato);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.partido_combo_box);
            this.Controls.Add(this.data_nascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigo_candidato);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.salvar_cand);
            this.Name = "CandidatoCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidatoCRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigo_candidato;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button salvar_cand;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker data_nascimento;
        private System.Windows.Forms.ComboBox partido_combo_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.ComboBox tipo_candidato;
        private System.Windows.Forms.ComboBox vice_prefeito;
        private System.Windows.Forms.Label vice_prefeito_label;
    }
}