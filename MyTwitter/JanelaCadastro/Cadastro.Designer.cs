namespace MyTwitter.JanelaCadastro
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textIdentidade = new System.Windows.Forms.TextBox();
            this.checkMostrar = new System.Windows.Forms.CheckBox();
            this.checkCpf = new System.Windows.Forms.CheckBox();
            this.checkCnpj = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 12F);
            this.label1.Location = new System.Drawing.Point(298, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Perfil";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(198, 179);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(433, 20);
            this.textNome.TabIndex = 1;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(198, 218);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(366, 20);
            this.textSenha.TabIndex = 2;
            // 
            // textIdentidade
            // 
            this.textIdentidade.Location = new System.Drawing.Point(198, 255);
            this.textIdentidade.Name = "textIdentidade";
            this.textIdentidade.Size = new System.Drawing.Size(250, 20);
            this.textIdentidade.TabIndex = 3;
            this.textIdentidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // checkMostrar
            // 
            this.checkMostrar.AutoSize = true;
            this.checkMostrar.Location = new System.Drawing.Point(570, 221);
            this.checkMostrar.Name = "checkMostrar";
            this.checkMostrar.Size = new System.Drawing.Size(61, 17);
            this.checkMostrar.TabIndex = 4;
            this.checkMostrar.Text = "Mostrar";
            this.checkMostrar.UseVisualStyleBackColor = true;
            this.checkMostrar.CheckedChanged += new System.EventHandler(this.checkMostrar_CheckedChanged);
            // 
            // checkCpf
            // 
            this.checkCpf.AutoSize = true;
            this.checkCpf.Location = new System.Drawing.Point(454, 258);
            this.checkCpf.Name = "checkCpf";
            this.checkCpf.Size = new System.Drawing.Size(42, 17);
            this.checkCpf.TabIndex = 5;
            this.checkCpf.Text = "Cpf";
            this.checkCpf.UseVisualStyleBackColor = true;
            this.checkCpf.CheckedChanged += new System.EventHandler(this.checkCpf_CheckedChanged);
            // 
            // checkCnpj
            // 
            this.checkCnpj.AutoSize = true;
            this.checkCnpj.Location = new System.Drawing.Point(502, 258);
            this.checkCnpj.Name = "checkCnpj";
            this.checkCnpj.Size = new System.Drawing.Size(47, 17);
            this.checkCnpj.TabIndex = 6;
            this.checkCnpj.Text = "Cnpj";
            this.checkCnpj.UseVisualStyleBackColor = true;
            this.checkCnpj.CheckedChanged += new System.EventHandler(this.checkCnpj_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code", 10F);
            this.label3.Location = new System.Drawing.Point(139, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Code", 10F);
            this.label4.Location = new System.Drawing.Point(94, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Identidade";
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.Font = new System.Drawing.Font("Fira Code SemiBold", 8.25F);
            this.buttonContinuar.Location = new System.Drawing.Point(280, 319);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(81, 23);
            this.buttonContinuar.TabIndex = 10;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Font = new System.Drawing.Font("Fira Code SemiBold", 8.25F);
            this.buttonVoltar.Location = new System.Drawing.Point(406, 319);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(81, 23);
            this.buttonVoltar.TabIndex = 11;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(807, 478);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkCnpj);
            this.Controls.Add(this.checkCpf);
            this.Controls.Add(this.checkMostrar);
            this.Controls.Add(this.textIdentidade);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cadastro_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textIdentidade;
        private System.Windows.Forms.CheckBox checkMostrar;
        private System.Windows.Forms.CheckBox checkCpf;
        private System.Windows.Forms.CheckBox checkCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.Button buttonVoltar;
    }
}