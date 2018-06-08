namespace UrnaEletronica
{
    partial class TelaInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.adm = new MaterialSkin.Controls.MaterialFlatButton();
            this.button1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // adm
            // 
            this.adm.AutoSize = true;
            this.adm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adm.Depth = 0;
            this.adm.Location = new System.Drawing.Point(85, 103);
            this.adm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.adm.MouseState = MaterialSkin.MouseState.HOVER;
            this.adm.Name = "adm";
            this.adm.Primary = false;
            this.adm.Size = new System.Drawing.Size(121, 36);
            this.adm.TabIndex = 2;
            this.adm.Text = "ADMINISTRADOR";
            this.adm.UseVisualStyleBackColor = true;
            this.adm.Click += new System.EventHandler(this.adm_Click_1);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Depth = 0;
            this.button1.Location = new System.Drawing.Point(106, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = false;
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "ELEIÇÃO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Teste";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Urna";
            this.notifyIcon1.Visible = true;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adm);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urna Eletrônica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton adm;
        private MaterialSkin.Controls.MaterialFlatButton button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

